<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
     .paginator
{
  font: 12px Arial, Helvetica, sans-serif;
  padding: 10px 20px 10px 0;
  margin: 0px auto;
}
 
.paginator a
{
  border: solid 1px #ccc;
  color: #0063dc;
  cursor: pointer;
  text-decoration: none;
}
 
.paginator a:visited
{
  padding: 1px 6px;
  border: solid 1px #ddd;
  background: #fff;
  text-decoration: none;
}
 
.paginator .cpb
{
  border: 1px solid #F50;
  font-weight: 700;
  color: #F50;
  background-color: #ffeee5;
}
 
.paginator a:hover
{
  border: solid 1px #F50;
  color: #f60;
  text-decoration: none;
}
 
.paginator a, .paginator a:visited, .paginator .cpb, .paginator a:hover
{
  float: left;
  height: 16px;
  line-height: 16px;
  min-width: 10px;
  _width: 10px;
  margin-right: 5px;
  text-align: center;
  white-space: nowrap;
  font-size: 12px;
  font-family: Arial,SimSun;
  padding: 0 3px;
}
 
.paginator label
{
  display:block;  
  float:left;  
}

   </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr><td>姓名</td><td>年龄</td><td>性别</td></tr>

                <%if (StuList != null)
                    {%>
                <%for (int i = 0; i < StuList.Count; i++)
                    {
                %>
                <tr>
                    <td>
                        <%=StuList[i].Name.ToString()%>
                    </td>
                    <td>
                        <%=StuList[i].sex.ToString()%>
                    </td>
                    <td>
                        <%=StuList[i].age.ToString()%>
                    </td>
                </tr>
                <%  
                    }
                %>
                <% } %>
            </table>
         <table>
          <tr class="">
    <td colspan="5" align="center" class="paginator">
      <span>
   <%=Navstring %>

      </span>
    </td>
  </tr>
             </table>
        </div>
    </form>
     
</body>
   
</html>
