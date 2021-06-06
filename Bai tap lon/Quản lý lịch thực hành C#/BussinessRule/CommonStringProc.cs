using System;
using System.Collections.Generic;
using System.Text;

namespace MDS.BussinessRule
{
    public class CommonStringProc
    {

        public string Left(string StrIn,int length)
        {
            string tmpstr = StrIn.Substring(0, length);
            return tmpstr;
        }
        public string Right(string StrIn,int length)
        {
            string tmpstr = StrIn.Substring(StrIn.Length - length, length);
            return tmpstr;
        }
        public string Mid(string StrIn,int startIndex, int length)
        {
            string tmpstr = StrIn.Substring(startIndex,length);
            return tmpstr;
        }
        public string Mid(string StrIn,int startIndex)
        {
            string tmpstr = StrIn.Substring(startIndex);
            return tmpstr;
        }
        public int InStr(string StrIn,string strCompare)
        {
            int ret = StrIn.IndexOf(strCompare);
            return ret;
        }
        public int InStrRev(string StrIn, string strCompare)
        {
            int ret = StrIn.LastIndexOf(strCompare);
            return ret;
        }

        public string Trim(string StrIn)
        {
            string ret = StrIn.Trim();
            return ret;
        }

        public string UCase(string StrIn)
        {
            string tmpstr = StrIn.ToUpper();
            return tmpstr;
        }
        public string LCase(string StrIn)
        {
            string tmpstr = StrIn.ToLower();
            return tmpstr;
        }
        public int Len(string StrIn)
        {
            int ret = StrIn.Length;
            return ret;
        }

       ////purpose : bo dau trong cau tieng viet
       //// in : xau can bo
       //// out : xau da duoc bo
       //public string CutVietnameseAccent(string strInputs)
       // {
       //     string strNoAccentChar;
       //     string strOutput = "";
       //     string strInput;
       //     int inti;
       //     string ReturnValue = "";

       //     if (strInputs + "" == "")
       //     {
       //         return null;
       //     }
       //     for (inti = 0; inti <= strInputs.Length - 1; inti++)
       //     {
       //         strInput = strInputs.Chars(inti);
       //         if (InStr("A,À,Á,Ả,Ã,Ạ,Â,Ầ,Ấ,Ẩ,Ẫ,Ậ,Ă,Ằ,Ắ,Ẳ,Ẵ,Ặ", strInput) > 0)
       //         {
       //             strNoAccentChar = "A";
       //         }
       //         else if (InStr("a,à,á,ả,ã,ạ,â,ầ,ấ,ẩ,ẫ,ậ,ă,ằ,ắ,ẳ,ẵ,ặ", strInput) > 0)
       //         {
       //             strNoAccentChar = "a";
       //         }
       //         else if (InStr("E,È,É,Ẻ,Ẽ,Ẹ,Ê,Ề,Ế,Ể,Ễ,Ệ", strInput) > 0)
       //         {
       //             strNoAccentChar = "E";
       //         }
       //         else if (InStr("e,è,é,ẻ,ẽ,ẹ,ê,ề,ế,ể,ễ,ệ", strInput) > 0)
       //         {
       //             strNoAccentChar = "e";
       //         }
       //         else if (InStr("U,Ù,Ú,Ủ,Ũ,Ụ,Ư,Ừ,Ứ,Ử,Ữ,Ự", strInput) > 0)
       //         {
       //             strNoAccentChar = "U";
       //         }
       //         else if (InStr("u,ù,ú,ủ,ũ,ụ,ư,ừ,ứ,ử,ữ,ự", strInput) > 0)
       //         {
       //             strNoAccentChar = "u";
       //         }
       //         else if (InStr("I,Ì,Í,Ỉ,Ĩ,Ị", strInput) > 0)
       //         {
       //             strNoAccentChar = "I";
       //         }
       //         else if (InStr("i,ì,í,ỉ,ĩ,ị", strInput) > 0)
       //         {
       //             strNoAccentChar = "i";
       //         }
       //         else if (InStr("O,Ò,Ó,Ỏ,Õ,Ọ,Ô,Ồ,Ố,Ổ,Ỗ,Ộ,Ơ,Ờ,Ớ,Ở,Ỡ,Ợ", strInput) > 0)
       //         {
       //             strNoAccentChar = "O";
       //         }
       //         else if (InStr("o,ò,ó,ỏ,õ,ọ,ô,ồ,ố,ổ,ỗ,ộ,ơ,ờ,ớ,ở,ỡ,ợ", strInput) > 0)
       //         {
       //             strNoAccentChar = "o";
       //         }
       //         else if (InStr("Y,Ỳ,Ý,Ỷ,Ỹ,Ỵ", strInput) > 0)
       //         {
       //             strNoAccentChar = "Y";
       //         }
       //         else if (InStr("y,ỳ,ý,ỷ,ỹ,ỵ", strInput) > 0)
       //         {
       //             strNoAccentChar = "y";
       //         }
       //         else if (InStr("đ", strInput) > 0)
       //         {
       //             strNoAccentChar = "d";
       //         }
       //         else if (InStr("Đ", strInput) > 0)
       //         {
       //             strNoAccentChar = "D";
       //         }
       //         else
       //         {
       //             strNoAccentChar = strInput;
       //         }
       //         strOutput = strOutput + strNoAccentChar;
       //     }
       //     CutVietnameseAccent = strOutput;
       // }


       // // purpose : do^`ng bo^. da^'u ddoi vo+'i xa^u tie^'ng vie^.t
       // // in : xa^u ca^`n ddo^`ng bo^.
       // // out : xa^u dda~ ddo^`ng bo^.
       // public string SyncAccent(string StrSA)
       // {
       //     string[] saArr1 = { "OÀ", "OÁ", "OẠ", "OẢ", "OÃ", "UỶ", "UÝ", "UỴ", "UỸ", "UỲ", "OÈ", "OÉ", "OẸ", "OẺ", "OẼ" };
       //     string[] saArr2 = { "ÒA", "ÓA", "ỌA", "ỎA", "ÕA", "ỦY", "ÚY", "ỤY", "ŨY", "ÙY", "ÒE", "ÓE", "ỌE", "ỎE", "ÕE" };
       //     if (Trim(StrSA) != "")
       //     {
       //         byte saIdx;
       //         for (int saIdx = LBound(saArr1); saIdx <= UBound(saArr1); saIdx++)
       //         {
       //             StrSA = Replace(StrSA, saArr2(saIdx), saArr1(saIdx));
       //         }
       //     }
       //     else
       //     {
       //         strErrorMsg = "Empty String";
       //     }
       //     SyncAccent = StrSA;
       // }

       // //
       // public string EncryptedPassword(string strVal)
       // {
       //     string strRet;
       //     XCrypt.XCryptEngine objXe;
       //     objXe = new XCrypt.XCryptEngine(XCrypt.XCryptEngine.AlgorithmType.MD5);
       //     strRet = objXe.Encrypt(strVal, "pl");
       //     objXe = null;
       //     EncryptedPassword = strRet;
       // }

       // //Cut vietnamese accent method
       // //INPUT: vietnamese accent string
       // //OUTPUT: string with no accent
       // public string FormNoAccentString(string strInput)
       // {
       //     string strNoAccentChar;
       //     string strResult = "";
       //     string strCurrentchar;
       //     if (!(Trim(strInput) == ""))
       //     {
       //         int intPos;
       //         for (int intPos = 1; intPos <= Len(strInput); intPos++)
       //         {
       //             strCurrentchar = Mid(strInput, intPos, 1);
       //             if (!(Trim(strCurrentchar) == ""))
       //             {
       //                 if (InStr("A,À,Á,Ả,Ã,Ạ,Â,Ầ,Ấ,Ẩ,Ẫ,Ậ,Ă,Ằ,Ắ,Ẳ,Ẵ,Ặ", strCurrentchar) > 0)
       //                 {
       //                     strNoAccentChar = "A";
       //                 }
       //                 else if (InStr("E,È,É,Ẻ,Ẽ,Ẹ,Ê,Ề,Ế,Ể,Ễ,Ệ", strCurrentchar) > 0)
       //                 {
       //                     strNoAccentChar = "E";
       //                 }
       //                 else if (InStr("U,Ù,Ú,Ủ,Ũ,Ụ,Ư,Ừ,Ứ,Ử,Ữ,Ự", strCurrentchar) > 0)
       //                 {
       //                     strNoAccentChar = "U";
       //                 }
       //                 else if (InStr("I,Ì,Í,Ỉ,Ĩ,Ị", strCurrentchar) > 0)
       //                 {
       //                     strNoAccentChar = "I";
       //                 }
       //                 else if (InStr("O,Ò,Ó,Ỏ,Õ,Ọ,Ô,Ồ,Ố,Ổ,Ỗ,Ộ,Ơ,Ờ,Ớ,Ở,Ỡ,Ợ", strCurrentchar) > 0)
       //                 {
       //                     strNoAccentChar = "O";
       //                 }
       //                 else if (InStr("Y,Ỳ,Ý,Ỷ,Ỹ,Ỵ", strCurrentchar) > 0)
       //                 {
       //                     strNoAccentChar = "Y";
       //                 }
       //                 else if (InStr("Đ", strCurrentchar) > 0)
       //                 {
       //                     strNoAccentChar = "D";
       //                 }
       //                 else
       //                 {
       //                     strNoAccentChar = strCurrentchar;
       //                 }
       //             }
       //             strResult = strResult + strNoAccentChar;
       //         }
       //     }
       //     else
       //     {
       //         strResult = strInput;
       //     }
       //     FormNoAccentString = strResult;
       // }

       // public void GLoadArray(string strInput, ref object objArr, string strDeli)
       // {
       //     int intIndex1;
       //     int intIndex2;
       //     int intIndex3;
       //     string strWord;
       //     strInput = Trim(strInput);
       //     intIndex1 = 0;
       //     while (Len(strInput) > 0)
       //     {
       //         // TODO: NotImplemented statement: ICSharpCode.SharpRefactory.Parser.AST.VB.ReDimStatement 
       //         intIndex2 = InStr(strInput, strDeli);
       //         if (intIndex2 > 0)
       //         {
       //             strWord = Left(strInput, intIndex2 - 1);
       //             strInput = Right(strInput, Len(strInput) - intIndex2 - Len(strDeli) + 1);
       //             objArr(intIndex1) = strWord;
       //             intIndex1 = intIndex1 + 1;
       //         }
       //         else
       //         {
       //             objArr(intIndex1) = strInput;
       //             strInput = "";
       //         }
       //     }
       // }

       // public string ReplaceBracket(string strInput)
       // {
       //     int start;
       //     int startend;
       //     int at;
       //     int et;
       //     int end;
       //     int count;
       //     end = strInput.Length;
       //     start = 0;
       //     count = 0;
       //     at = 0;
       //     et = 0;
       //     while (start <= end && at > -1)
       //     {
       //         count = end - start;
       //         at = strInput.IndexOf("<", start, count);
       //         if (at == -1)
       //         {
       //             goto exitWhileStatement0;
       //         }
       //         else if (at == 0)
       //         {
       //             et = strInput.IndexOf(">", 1, count - 1);
       //         }
       //         else
       //         {
       //             et = strInput.IndexOf(">", start + 1, count - 1);
       //         }
       //         if (et > 0)
       //         {
       //             start = et;
       //         }
       //         else
       //         {
       //             start = at + 1;
       //         }
       //         if (et > 0)
       //         {
       //             if (strInput.Substring(at, et - at + 1).ToUpper != "<BR>")
       //             {
       //                 string tem;
       //                 tem = strInput.Substring(at, et - at + 1);
       //                 tem = tem.Replace("<", "&");
       //                 tem = tem.Replace(">", "@");
       //                 strInput = strInput.Replace(strInput.Substring(at, et - at + 1), tem);
       //             }
       //         }
       //     }
       // exitWhileStatement0: ;
       // }



    }
}
