using PP11.Forms.Base;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Word = Microsoft.Office.Interop.Word;

namespace PP11.Forms
{
    public partial class AdministratorForm : PanelUserPatternForm
    {
        private Chart chart;
        public AdministratorForm()
        {
            InitializeComponent();
            labelHeader.Text = "Панель администратора";
            comboBox1.Items.Add("количество оказанных услуг по дням за период времени");
            comboBox1.Items.Add("количество заказов по дням за период времени по каждой услуге");
            comboBox1.Items.Add("количество заказов по дням за период времени");
            comboBox1.SelectedIndex = 0;
        }

        private async void AdministratorForm_Load(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();

            string query = @"SELECT e.[login] as ""Логин"", lh.login_date as ""Время входа"", tl.name as ""Результат""  FROM LoginHistory lh
                             LEFT JOIN Employees e ON  lh.id_employee = e.id
                             LEFT JOIN TypesLogin tl ON lh.id_type_login = tl.id";

            var resultHistoryLogin = await dataBase.SelectQuery(query);
            dataGridView1.DataSource = resultHistoryLogin;

            query = "SELECT o.id as \"Номер заказа\", o.datetime_create as \"Дата создания\", s.name as \"Статус\", CONCAT(cl.surname, ' ', cl.name, ' ', cl.patronymic) as \"ФИО клиента\", \r\no.rental_time as \"Время проката\", o.date_close as \"Время закрытия заказа\" FROM Orders o\r\nLEFT JOIN Clients cl ON cl.id = o.id_client\r\nLEFT JOIN Statuses s ON s.id = o.id_status ";
            var resultOrders = await dataBase.SelectQuery(query);
            dataGridView2.DataSource = resultOrders;
        }

        private async void buttonApplyFilters_Click(object sender, EventArgs e)
        {
            var result = await GetData();

            panelContainer.Controls.Clear();

            var checkedButton = groupBox1.Controls.OfType<RadioButton>()
                                         .FirstOrDefault(r => r.Checked);

            switch (checkedButton.Text)
            {
                case "Таблица":
                    CreateTable(result);
                    break;
                case "График":
                    CreateChart(result);
                    break;
                case "Таблица и график":
                    CreateTable(result, DockStyle.Bottom);
                    CreateChart(result, DockStyle.Top);
                    break;
            }
        }

        private async Task<DataTable> GetData()
        {
            var dateStart = dateTimePicker1.Value.ToString("yyyy-MM-dd") + "T00:00:00.000";
            var dateEnd = dateTimePicker2.Value.ToString("yyyy-MM-dd") + "T00:00:00.000";
            string query = "";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    query = $@"select Convert(date, o.datetime_create) as 'Дата', COUNT(os.id) as 'Количество услуг' from Orders o
                            inner join OrdersServices os on os.id_order = o.id
                            Where o.datetime_create >= '{dateStart}' and o.datetime_create <= '{dateEnd}'
                            group by o.datetime_create";
                    break;
                case 1:
                    query = $@"select Convert(date, DATEADD(DAY, DATEDIFF(DAY, 0, o.datetime_create), 0)) as 'Дата', COUNT(o.id) as 'Количество заказов' from Orders o
                               Where o.datetime_create >= '{dateStart}' and o.datetime_create <= '{dateEnd}'
                               group by DATEADD(DAY, DATEDIFF(DAY, 0, o.datetime_create), 0)";
                    break;
                case 2:
                    query = $@"select Convert(date, DATEADD(DAY, DATEDIFF(DAY, 0, o.datetime_create), 0)) as 'Дата', COUNT(o.id) as 'Количество заказов', s.name as 'Услуга' from Orders o
                               inner join OrdersServices os on os.id_order = o.id
                               inner join Services s on s.id = os.id_service
                               Where o.datetime_create >= '{dateStart}' and o.datetime_create <= '{dateEnd}'
                               group by DATEADD(DAY, DATEDIFF(DAY, 0, o.datetime_create), 0), s.name
                               order by DATEADD(DAY, DATEDIFF(DAY, 0, o.datetime_create), 0)";
                    break;
            }

            DataBase dataBase = new DataBase();

            var result = await dataBase.SelectQuery(query);

            return result;
        }

        private void CreateTable(DataTable result, DockStyle dockStyle = DockStyle.Fill)
        {
            var dgv = new DataGridView();
            dgv.Parent = panelContainer;
            dgv.Dock = dockStyle;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersHeight = 30;
            dgv.RowTemplate.Height = 25;
            dgv.DataSource = result;
        }

        private void CreateChart(DataTable result, DockStyle dockStyle = DockStyle.Fill)
        {
            chart = new Chart();
            chart.Parent = panelContainer;
            chart.Dock = dockStyle;

            if (comboBox1.SelectedIndex != 2)
            {
                chart.ChartAreas.Add(new ChartArea("Area 1"));
                chart.ChartAreas["Area 1"].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
                chart.ChartAreas["Area 1"].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.DashDotDot;
                chart.ChartAreas["Area 1"].AxisX.MajorGrid.LineColor = Color.DarkGray;
                chart.ChartAreas["Area 1"].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
                chart.ChartAreas["Area 1"].AxisY.Interval = 1;
                chart.ChartAreas["Area 1"].AxisY.MajorGrid.LineColor = Color.DarkGray;

                Series series = new Series("Series 1");
                series.ChartType = SeriesChartType.Line;
                series.ChartArea = "Area 1";
                series.ToolTip = "#VALX";
                series.MarkerStyle = MarkerStyle.Circle;
                series.Color = Color.DarkGreen;
                series.BorderWidth = 2;
                for (int i = 0; i < result.Rows.Count; i++)
                {
                    series.Points.AddXY((DateTime)result.Rows[i][0], (int)result.Rows[i][1]);
                    series.Points[i].MarkerSize = 5;
                }

                chart.Series.Add(series);
            }
            else
            {
                Random random = new Random();
                chart.ChartAreas.Add(new ChartArea("Area 1"));
                chart.ChartAreas["Area 1"].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
                chart.ChartAreas["Area 1"].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.DashDotDot;
                chart.ChartAreas["Area 1"].AxisX.MajorGrid.LineColor = Color.DarkGray;
                chart.ChartAreas["Area 1"].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
                chart.ChartAreas["Area 1"].AxisY.Interval = 1;
                chart.ChartAreas["Area 1"].AxisY.MajorGrid.LineColor = Color.DarkGray;


                foreach (DataRow item in result.Rows)
                {
                    string serviceName = (string)item[2];
                    if (chart.Series.IsUniqueName(serviceName))
                    {
                        var series = new Series(serviceName);
                        series.MarkerSize = 5;
                        series.ChartType = SeriesChartType.Line;
                        series.ChartArea = "Area 1";
                        series.ToolTip = "#VALX";
                        series.MarkerStyle = MarkerStyle.Circle;
                        series.Color = new SolidBrush(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255))).Color;
                        series.BorderWidth = 2;
                        series.LegendText = serviceName;
                        series.IsVisibleInLegend = true;
                        series.Points.AddXY((DateTime)item[0], (int)item[1]);

                        chart.Legends.Add(serviceName);
                        chart.Legends[serviceName].Name = serviceName;
                        chart.Series.Add(series);
                        chart.Legends[serviceName].Alignment = StringAlignment.Near;
                        chart.Legends[serviceName].Docking = Docking.Right;
                        chart.Legends[serviceName].DockedToChartArea = "Area 1";
                        chart.Legends[serviceName].IsDockedInsideChartArea = true;
                        chart.Legends[serviceName].LegendStyle = LegendStyle.Table;
                        chart.Legends[serviceName].TableStyle = LegendTableStyle.Auto;
                        chart.Legends[serviceName].IsEquallySpacedItems = false;
                        chart.Legends[serviceName].Position.Width = 20;
                        chart.Legends[serviceName].Position.Height = 40;
                        chart.Legends[serviceName].Position.X = 80;
                    }
                    else
                    {
                        chart.Series[serviceName].Points.AddXY((DateTime)item[0], (int)item[1]);
                    }
                }
            }
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.pdf)|*.pdf|All files(*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog.FileName;

            Word.Document doc = null;
            Word.Application app = new Word.Application();

            string source = AppDomain.CurrentDomain.BaseDirectory + "patternReport.docx";
            doc = app.Documents.Open(source);
            doc.Activate();

            doc.SaveAs2(AppDomain.CurrentDomain.BaseDirectory + @"patternReport2.docx");
            doc.Close();
            doc = null;

            doc = app.Documents.Open(AppDomain.CurrentDomain.BaseDirectory + @"patternReport2.docx");
            doc.Activate();

            Word.Bookmarks wBookmarks = doc.Bookmarks;
            Word.Range wRange;

            var result = await GetData();

            var checkedButton = groupBox1.Controls.OfType<RadioButton>()
                                         .FirstOrDefault(r => r.Checked);

            try
            {
                switch (checkedButton.Text)
                {
                    case "Таблица":
                        Word.Range range = app.Selection.Range;
                        Object behiavor = Word.WdDefaultTableBehavior.wdWord9TableBehavior;
                        Object autoFitBehiavor = Word.WdAutoFitBehavior.wdAutoFitFixed;
                        int columns = result.Columns.Count;
                        int rows = result.Rows.Count;
                        doc.Bookmarks.get_Item("s1").Range.Tables.Add(doc.Bookmarks.get_Item("s1").Range, rows + 1, columns, ref behiavor, ref autoFitBehiavor);
                        for (int i = 1; i <= columns; i++)
                        {
                            doc.Tables[1].Cell(1, i).Range.Text = result.Columns[i - 1].ColumnName;

                            for (int j = 0; j < rows; j++)
                            {
                                doc.Tables[1].Cell(j + 2, i).Range.Text = result.Rows[j][i - 1].ToString();
                            }
                        }
                        doc.SaveAs2(AppDomain.CurrentDomain.BaseDirectory + "testReport.docx");
                        doc.SaveAs2(filename, Word.WdSaveFormat.wdFormatPDF);
                        break;
                    case "График":
                        var tmp = Path.GetTempFileName();
                        tmp = tmp.Substring(0, tmp.LastIndexOf(".") + 1) + "png";
                        chart.SaveImage(tmp, ChartImageFormat.Png);
                        doc.InlineShapes.AddPicture(tmp, Type.Missing, Type.Missing, doc.Bookmarks["s2"].Range);
                        doc.SaveAs2(AppDomain.CurrentDomain.BaseDirectory + "testReport.docx");
                        doc.SaveAs2(filename, Word.WdSaveFormat.wdFormatPDF);
                        break;
                    case "Таблица и график":
                        var tmp1 = Path.GetTempFileName();
                        tmp1 = tmp1.Substring(0, tmp1.LastIndexOf(".") + 1) + "png";
                        chart.SaveImage(tmp1, ChartImageFormat.Png);
                        doc.InlineShapes.AddPicture(tmp1, Type.Missing, Type.Missing, doc.Bookmarks["s2"].Range);

                        Word.Range range1 = app.Selection.Range;
                        Object behiavor1 = Word.WdDefaultTableBehavior.wdWord9TableBehavior;
                        Object autoFitBehiavor1 = Word.WdAutoFitBehavior.wdAutoFitFixed;
                        int columns1 = result.Columns.Count;
                        int rows1 = result.Rows.Count;
                        doc.Bookmarks.get_Item("s1").Range.Tables.Add(doc.Bookmarks.get_Item("s1").Range, rows1 + 1, columns1, ref behiavor1, ref autoFitBehiavor1);
                        for (int i = 1; i <= columns1; i++)
                        {
                            doc.Tables[1].Cell(1, i).Range.Text = result.Columns[i - 1].ColumnName;

                            for (int j = 0; j < rows1; j++)
                            {
                                doc.Tables[1].Cell(j + 2, i).Range.Text = result.Rows[j][i - 1].ToString();
                            }
                        }

                        doc.SaveAs2(AppDomain.CurrentDomain.BaseDirectory + "testReport.docx");
                        doc.SaveAs2(filename, Word.WdSaveFormat.wdFormatPDF);
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                doc.Close();
                doc = null;
            }

            MessageBox.Show("Отчет сохранен");
        }
    }
}
