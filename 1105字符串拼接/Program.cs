using System.Runtime.InteropServices;

Console.WriteLine("字符串拼接");

#region 方式1(可拼接不同类型变量）!!!只能用+（或+=）运算符拼接字符串
string str1 = "Hello";
string str2 = "World";
string add1 = str1 + " " + str2;
string add_different_type = str1 + " " + 123 + 12.33;
Console.WriteLine(add1);
#endregion

#region 方式2
string add2 = string.Format("{0} {1}", str1, str2);
Console.WriteLine(add2);
#endregion  

#region 方式3
string add3 = string.Join(" ", str1, str2);
Console.WriteLine(add3);
#endregion
