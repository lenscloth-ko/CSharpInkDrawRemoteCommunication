using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InkdrawRemoteComWin
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();

            SetSampleData();
        }

        private void SetSampleData()
        {
            DataTable mesOrderTable = new DataTable("mesOrderTable");

            mesOrderTable.Columns.Add("Line", typeof(string));
            mesOrderTable.Columns.Add("Grade", typeof(string));
            mesOrderTable.Columns.Add("Color", typeof(string));
            mesOrderTable.Columns.Add("LotNo", typeof(string));
            mesOrderTable.Columns.Add("SerialStart", typeof(string));
            mesOrderTable.Columns.Add("SerialEnd", typeof(string));
            mesOrderTable.Columns.Add("PrintYN", typeof(string));
            mesOrderTable.Columns.Add("PrintDate", typeof(string));

            //mesOrderTable.Rows.Add(new object[] {"AAA", "AAA", "AAA", "AAA", "AAA", "AAA" });
            mesOrderTable.Rows.Add(new object[] { "1", "TR654", "INP", "E18Z05J-01", "1", "40", "N", "" });
            mesOrderTable.Rows.Add(new object[] { "1", "DP270E", "NP", "418X0160", "1", "50", "N", "" });
            mesOrderTable.Rows.Add(new object[] { "1", "L1912", "WS8Q766", "Z18825K-01", "1", "40", "N", "" });
            mesOrderTable.Rows.Add(new object[] { "1", "XR404", "G9211", "Z18910D-09", "1", "40", "N", "" });

            dgvMESOrder.DataSource = mesOrderTable;
        }

        private void dgvMESOrder_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMESOrder.CurrentRow != null)
            {
                lblLine01.Text = dgvMESOrder.Rows[dgvMESOrder.CurrentRow.Index].Cells["Grade"].Value.ToString();
                lblLine02.Text = dgvMESOrder.Rows[dgvMESOrder.CurrentRow.Index].Cells["Color"].Value.ToString();
                lblLine03.Text = dgvMESOrder.Rows[dgvMESOrder.CurrentRow.Index].Cells["LotNo"].Value.ToString();
                //lblLine04.Text = string.Format("{0}-{1}"
                //    , dgvMESOrder.Rows[dgvMESOrder.CurrentRow.Index].Cells["Grade"].Value.ToString()
                //    , dgvMESOrder.Rows[dgvMESOrder.CurrentRow.Index].Cells["LotNo"].Value.ToString()
                //    );
                lblLine04.Text = string.Format("{0}"
                    , dgvMESOrder.Rows[dgvMESOrder.CurrentRow.Index].Cells["LotNo"].Value.ToString()
                    //, dgvMESOrder.Rows[dgvMESOrder.CurrentRow.Index].Cells["LotNo"].Value.ToString()
                    );

                //MessageBox.Show(
                //    dgvMESOrder.Rows[dgvMESOrder.CurrentRow.Index].Cells["Grade"].Value.ToString()


                //    //dgvMESOrder.CurrentRow.Index.ToString()

                //    );
            }
            else
            {

            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                //마킹기 Object 정보
                // TGRADE , TCOLOR , TLOTNO , TTOTAL , CSerial1 , TQR
                StringBuilder sb = new StringBuilder();

                //Grade
                sb.AppendFormat("OBJECT:TGRADE;TEX;{0}#", lblLine01.Text);
                //Color
                sb.AppendFormat("OBJECT:TCOLOR;TEX;{0}#", lblLine02.Text);
                //Lot No
                sb.AppendFormat("OBJECT:TLOTNO;TEX;{0}#", lblLine03.Text);
                //Total
                sb.AppendFormat("OBJECT:TTOTAL;TEX;{0}#", lblLine04.Text);

                //프린트 명령
                //sb.Append("COMMAND:F;ABS_TEST01#");

                //Ping
                //sb.Append("REQUEST:print ready#");

                AddLog("send----------------");
                AddLog(sb.ToString());
                //MessageBox.Show(sb.ToString());

                //OBJECT:TGRADE;TEX;L1912#OBJECT:TCOLOR;TEX;WS8Q766#OBJECT:TLOTNO;TEX;Z18825K-01#OBJECT:TTOTAL;TEX;L1912-Z18825K-01#

                // (1) IP 주소와 포트를 지정하고 TCP 연결 
                TcpClient tc = new TcpClient("10.32.225.132", 6020);
                //TcpClient tc = new TcpClient("localhost", 7000);

                //string msg = "OBJECT:TGRADE;TEX;L1912#OBJECT:TCOLOR;TEX;WS8Q766#OBJECT:TLOTNO;TEX;Z18825K-01#OBJECT:TTOTAL;TEX;L1912-Z18825K-01#";
                //string msg = "OBJECT:TGRADE;TEX;L1912-01#";
                //string msg = "OBJECT:TGRADE;TEX;L1912#OBJECT:TCOLOR;TEX;WS8Q766#";
                //string msg = "OBJECT:TGRADE;TEX;L1912#OBJECT:TCOLOR;TEX;WS8Q766#OBJECT:TLOTNO;TEX;Z18825K-01#";
                //string msg = "OBJECT:TGRADE;TEX;L1912#OBJECT:TCOLOR;TEX;WS8Q766#OBJECT:TLOTNO;TEX;Z18825K-01#OBJECT:TTOTAL;TEX;L1912-Z18825K-01#";
                //string msg = "OBJECT:TTOTAL;TEX;L1912-Z18825K-01#";

                string msg = sb.ToString();
                byte[] buff = Encoding.ASCII.GetBytes(msg);

                // (2) NetworkStream을 얻어옴 
                NetworkStream stream = tc.GetStream();

                // (3) 스트림에 바이트 데이타 전송
                stream.Write(buff, 0, buff.Length);

                // (4) 스트림으로부터 바이트 데이타 읽기
                byte[] outbuf = new byte[1024];
                int nbytes = stream.Read(outbuf, 0, outbuf.Length);
                string output = Encoding.ASCII.GetString(outbuf, 0, nbytes);

                // (5) 스트림과 TcpClient 객체 닫기
                stream.Close();
                tc.Close();

                AddLog("recieve----------------");
                AddLog($"{nbytes} bytes: {output}");

                //Console.WriteLine($"{nbytes} bytes: {output}");
            }
            catch (Exception ex)
            {
                AddLog(ex.Message);
            }
        } // click event

        private void AddLog(string txt)
        {
            lbxLog.Items.Add(txt);
            lbxLog.SelectedIndex = lbxLog.Items.Count - 1;
            //listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
    }
}





