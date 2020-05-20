using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockEval
{
    public partial class StockEval : Form
    {
        private int counter = 0;
        DataTable table;
        WebCrawl web = new WebCrawl();
        public StockEval()
        {
            InitializeComponent();
            InitTable();
        }
        private void InitTable()
        {
            table = new DataTable("Stock Data");
            //Stats info
            table.Columns.Add("Stock Name", typeof(string)); //0
            table.Columns.Add("Market Cap", typeof(string)); //1
            table.Columns.Add("Price to Earnings", typeof(string));//2 
            table.Columns.Add("Price to Book", typeof(string)); //3
            table.Columns.Add("Profit/Sales", typeof(string)); //4
            table.Columns.Add("Dividend Yield", typeof(string)); //5
            table.Columns.Add("Enterprise to Revenue", typeof(string));//6
            table.Columns.Add("Enterprise to EBITDA", typeof(string)); //7
            table.Columns.Add("Operating Cash Flow", typeof(string));//8
            table.Columns.Add("Operating Margin", typeof(string));//9
            table.Columns.Add("Profit Margin", typeof(string));//10
            table.Columns.Add("Given Return on Equity", typeof(string));//11 
            //Balance sheet Info
            table.Columns.Add("Total Assets", typeof(string)); //12
            table.Columns.Add("Intangible Assets", typeof(string));//13
            table.Columns.Add("Goodwill", typeof(string)); //14
            table.Columns.Add("Current Assets", typeof(string));//15 
            table.Columns.Add("Total Liabilities", typeof(string));//16
            table.Columns.Add("Current Liabilities", typeof(string));//17
            table.Columns.Add("Accounts Receivable", typeof(string));//18
            table.Columns.Add("Inventory", typeof(string));//19
            table.Columns.Add("Other Current Assets", typeof(string));//20
            table.Columns.Add("Accounts Payable", typeof(string));//21
            table.Columns.Add("Long Term Debt", typeof(string));//22
            table.Columns.Add("Taxes Payable", typeof(string));//23
            table.Columns.Add("Fixed Assets", typeof(string));//24
            table.Columns.Add("Equity", typeof(string));//25
            //Income stmt 
            table.Columns.Add("Sales", typeof(string));//26
            table.Columns.Add("Net Income", typeof(string));//27
            table.Columns.Add("Operating Income or Loss", typeof(string));//28
            //Calculations
            table.Columns.Add("Calculated Return on Equity", typeof(string));//29
            table.Columns.Add("Current Ratio", typeof(string));//30
            table.Columns.Add("Liquid Ratio", typeof(string));//31
            table.Columns.Add("Networking Capital", typeof(string));//32
            table.Columns.Add("Quick Ratio", typeof(string));//33
            table.Columns.Add("Debt Ratio", typeof(string));//34
            table.Columns.Add("Times Interest Earned", typeof(string));//35
            table.Columns.Add("Basic Earning Power", typeof(string));//36
            stockData.DataSource = table;
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            string url = inputURL.Text;
            List<string> editedUrls = web.UrlBuilder(url);
            List<string> data = await web.ReqData(editedUrls);

            TableBuilder(data);
            data = DataDiver();
            var t = "";
        }
        
        private void TableBuilder(List<string> data)
        {
            if (data.Count == 147)
            {
                table.Rows.Add(data[0], data[1], data[3], data[7], data[6], data[31], data[8], data[9], data[58], data[41], data[40], data[43],
                    data[79], data[76], data[75], data[68], data[96], data[89], data[65], data[66], data[67], data[84], data[91], data[85],
                    data[78], data[101], data[103], data[127], data[117]);
            }
            else if (data.Count == 191)
            {
                table.Rows.Add(data[0], data[1], data[3], data[7], data[6], data[31], data[8], data[9], data[58], data[41], data[40], data[43],
                    data[99], data[93], data[91], data[77], data[133], data[119], data[71], data[73], data[75], data[109], data[123], data[111],
                    data[97], data[143], data[147], data[171], data[161]);
            }
        }

        private List<string> DataDiver()
        {
            List<string> dataCollection = new List<string>();
            for (int i = 0; i < 29; i++)
            {
                //dataCollection.Add(table.Rows[counter][i].ToString());
            }
            return dataCollection;
        }

        //private void IntoTheParams(List<string> data)
        //{
        //    float points = 0;
        //    float cap = 0;
        //    float cf = 0;
        //    if (data[1].Contains("B"))
        //    {
        //        cap = float.Parse(data[1].Substring(0, data[1].Length - 1)) * 1000000000;
        //    }
        //    else
        //    {
        //        cap = float.Parse(data[1].Substring(0, data[1].Length - 1)) * 1000000;
        //    }
        //    float pe = float.Parse(data[2]);
        //    float pb = float.Parse(data[3]);
        //    float ps = float.Parse(data[4]);
        //    float y = 0;
        //    if (data[5] == "0")
        //    {
        //        y = 0; 
        //    }
        //    else
        //    {
        //        y = float.Parse(data[5].Substring(0, data[5].Length - 1));
        //    }
        //    float er = float.Parse(data[6]);
        //    float ev = float.Parse(data[7]);
        //    float bv = float.Parse(data[8]);
        //    if (data[9].Contains("B"))
        //    {
        //        cf = float.Parse(data[9].Substring(0, data[9].Length - 1)) * 1000000000;
        //    }
        //    else if (data[9].Contains("M"))
        //    {
        //        cf = float.Parse(data[9].Substring(0, data[9].Length - 1)) * 1000000;
        //    }
        //    else
        //    {
        //        cf = float.Parse(data[9]);
        //    }
        //    float ta = float.Parse(data[10]) * 1000;
        //    float ia = float.Parse(data[11]) * 1000;
        //    float gw = float.Parse(data[12]) * 1000;
        //    float aa = float.Parse(data[13]) * 1000;
        //    float ca = float.Parse(data[14]) * 1000;
        //    float tl = float.Parse(data[15]) * 1000;
        //    float pref = float.Parse(data[16]);

        //    //
        //    //Params
        //    //
        //    if (pb >= .01 && pb <= 1)
        //    {
        //        points += 5;
        //    }
        //    else if (pb >= 1.01 && pb <= 1.99)
        //    {
        //        points += 4;
        //    }
        //    else if (pb >= 2 && pb <= 2.49)
        //    {
        //        points += 3;
        //    }
        //    else if (pb >= 2.5 && pb <= 2.99)
        //    {
        //        points += 2;
        //    }
        //    else
        //    {
        //        points += 1;
        //    }
        //    if (pe >= .01 && pe <= 10)
        //    {
        //        points += 5;
        //    }
        //    else if (pe >= 10.01 && pe <= 14.99)
        //    {
        //        points += 4;
        //    }
        //    else if (pe >= 15 && pe <= 19.99)
        //    {
        //        points += 3;
        //    }
        //    else if (pe >= 20 && pe <= 24.99)
        //    {
        //        points += 2;
        //    }
        //    else
        //    {
        //        points += 1;
        //    }
        //    if (ps >= .01 && ps <= 1)
        //    {
        //        points += 5;
        //    }
        //    else if (ps >= 1.01 && ps <= 1.99)
        //    {
        //        points += 4;
        //    }
        //    else if (ps >= 2 && ps <= 2.49)
        //    {
        //        points += 3;
        //    }
        //    else if (ps >= 2.5 && ps <= 2.99)
        //    {
        //        points += 2;
        //    }
        //    else
        //    {
        //        points += 1;
        //    }
        //    if (y >= 2.7)
        //    {
        //        points += 5;
        //    }
        //    else if (y <= 2.69 && y >= 2.4)
        //    {
        //        points += 4;
        //    }
        //    else if (y <= 2.2 && y >= 2.39)
        //    {
        //        points += 3;
        //    }
        //    else if (y >= 2.01 && y <= 2.19)
        //    {
        //        points += 2;
        //    }
        //    else
        //    {
        //        points += 1;
        //    }
        //    if (er <= 1.5)
        //    {
        //        points += 5;
        //    }
        //    else if (er >= 1.51 && er <= 2.1)
        //    {
        //        points += 4;
        //    }
        //    else if (er >= 2.11 && er <= 3)
        //    {
        //        points += 3;
        //    }
        //    else if (er >= 3.01 && er <= 5)
        //    {
        //        points += 2;
        //    }
        //    else
        //    {
        //        points += 1;
        //    }
        //    if (ev >= .01 && ev <= 7.99)
        //    {
        //        points += 5;
        //    }
        //    else if (ev >= 8 && ev <= 9.5)
        //    {
        //        points += 4;
        //    }
        //    else if (ev >= 9.51 && ev <= 10)
        //    {
        //        points += 3;
        //    }
        //    else if (ev >= 10.01 && ev <= 11.99)
        //    {
        //        points += 2;
        //    }
        //    else
        //    {
        //        points += 1;
        //    }
        //    if (bv >= 20)
        //    {
        //        points += 5;
        //    }
        //    else if (bv <= 19.99 && bv >= 15)
        //    {
        //        points += 4;
        //    }
        //    else if (bv <= 14.99 && bv <= 10)
        //    {
        //        points += 3;
        //    }
        //    else if (bv <= 9.99 && bv >= 5)
        //    {
        //        points += 2;
        //    }
        //    else
        //    {
        //        points += 1;
        //    }
        //    float pa = cap / ta;
        //    if (pa >= .01 && pa <= 1)
        //    {
        //        points += 5;
        //    }
        //    else if (pa >= 1.01 && pa <= 1.5)
        //    {
        //        points += 4;
        //    }
        //    else if (pa >= 1.51 && pa <= 2)
        //    {
        //        points += 3;
        //    }
        //    else if (pa >= 2.01 && pa <= 3)
        //    {
        //        points += 2;
        //    }
        //    else
        //    {
        //        points += 1;
        //    }
        //    float pta = cap / (ta - ia - gw - aa);
        //    if (pta >= .01 && pta <= 1)
        //    {
        //        points += 5;
        //    }
        //    else if (pta >= 1.01 && pta <= 1.99)
        //    {
        //        points += 4;
        //    }
        //    else if (pta >= 2 && pta <= 2.49)
        //    {
        //        points += 3;
        //    }
        //    else if (pta >= 2.5 && pta <= 2.99)
        //    {
        //        points += 2;
        //    }
        //    else
        //    {
        //        points += 1;
        //    }


        //    //float nc = cap / (ca - (tl + pref));
        //    //if (nc >= .01 && nc <= 1)
        //    //{
        //    //    points += 5;
        //    //}
        //    //else if (nc >= 1.01 && nc <= 2)
        //    //{
        //    //    points += 4;
        //    //}
        //    //else if (nc >= 2.01 && nc <= 3)
        //    //{
        //    //    points += 3;
        //    //}
        //    //else if (nc >= 3.01 && nc <= 5)
        //    //{
        //    //    points += 2;
        //    //}
        //    //else
        //    //{
        //    //    points += 1;
        //    //}


        //    float pcf = cap / cf;
        //    if (pcf >= .01 && pcf <= 5)
        //    {
        //        points += 5;
        //    }
        //    else if (pcf >= 5.01 && pcf <= 10)
        //    {
        //        points += 4;
        //    }
        //    else if (pcf >= 10.01 && pcf <= 15)
        //    {
        //        points += 3;
        //    }
        //    else if (pcf >= 15.01 && pcf <= 20)
        //    {
        //        points += 2;
        //    }
        //    else
        //    {
        //        points += 1;
        //    }
        //    //
        //    //End of Params
        //    //
        //    FinalGrade(points); 
        //}
        //private void FinalGrade(float points)
        //{
        //    string evaluation = "";
        //    float avg = points / 11;
        //    if (avg >= .01 && avg <= 1.49)
        //    {
        //        evaluation = "Strong Sell";
        //    }
        //    else if (avg >= 1.5 && avg <= 2.49)
        //    {
        //        evaluation = "Sell";
        //    }
        //    else if (avg >= 2.5 && avg <= 3.49)
        //    {
        //        evaluation = "Hold";
        //    }
        //    else if (avg >= 3.5 && avg <= 4.49)
        //    {
        //        evaluation = "Buy";
        //    }
        //    else if (avg >= 4.5 && avg <= 5)
        //    {
        //        evaluation = "Strong Buy"; 
        //    }
        //    else
        //    {
        //        MessageBox.Show("Guess Avg went out of bounds somehow");
        //    }
        //    test.Text = evaluation;

        //}
    }
}
