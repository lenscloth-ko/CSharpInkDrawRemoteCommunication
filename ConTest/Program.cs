using InkDrawRemoteCommunicationLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConTest
{
    class Program
    {
        static void Main(string[] args)
        {
            #region test
            //// (1) IP 주소와 포트를 지정하고 TCP 연결 
            //TcpClient tc = new TcpClient("10.32.225.132", 6020);
            ////TcpClient tc = new TcpClient("localhost", 7000);

            //string msg = "OBJECT:TGRADE;TEX;1111#OBJECT:TQR;CON;1111#";
            ////string msg = "OBJECT:TQR;CON;EXEDASDAWSDS#";
            //byte[] buff = Encoding.ASCII.GetBytes(msg);

            //// (2) NetworkStream을 얻어옴 
            //NetworkStream stream = tc.GetStream();

            //// (3) 스트림에 바이트 데이타 전송
            //stream.Write(buff, 0, buff.Length);

            //// (4) 스트림으로부터 바이트 데이타 읽기
            //byte[] outbuf = new byte[1024];
            //int nbytes = stream.Read(outbuf, 0, outbuf.Length);
            //string output = Encoding.ASCII.GetString(outbuf, 0, nbytes);

            //// (5) 스트림과 TcpClient 객체 닫기
            //stream.Close();
            //tc.Close();

            //Console.WriteLine($"{nbytes} bytes: {output}");
            #endregion
            //InkDrawCommand idc = new InkDrawCommand();

            InkDrawLib inkDrawLib = new InkDrawLib();

            //Console.WriteLine(idl.Close());
            //Console.WriteLine(idl.Text("TGRADE", "TR557"));

            inkDrawLib.CommandStartPrint();

            InkDrawErrorCodes ec = new InkDrawErrorCodes();

            Console.WriteLine(ec.ErrorMessage("000"));

            



            //Console.WriteLine(aa);
        }
    }
}
