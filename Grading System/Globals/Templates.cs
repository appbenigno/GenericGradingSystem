using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.UI;
using System.IO;


namespace Grading_System.Globals
{
    public class Templates
    {
        /// <summary>
        /// Blue HTML Template
        /// </summary>
        /// <param name="activityList"></param>
        /// <param name="entriesList"></param>
        /// <returns></returns>
        public static string Blue(ListView activityList, ListView entriesList)
        {
            StringBuilder strBldr = new StringBuilder();
            StringWriter strWriter = new StringWriter(strBldr);

            HtmlTextWriter writer = new HtmlTextWriter(strWriter);

            // DOCTYPE
            writer.WriteLine("<!DOCTYPE html>" + "\n");
            //<html>
            writer.RenderBeginTag(HtmlTextWriterTag.Html);
            // <head>
            writer.RenderBeginTag(HtmlTextWriterTag.Head);
            // <title>
            writer.RenderBeginTag(HtmlTextWriterTag.Title);
            writer.Write(ProjResource.ProjectTitle);
            // </title>
            writer.RenderEndTag();
            writer.WriteLine();

            // <style>
            writer.AddAttribute(HtmlTextWriterAttribute.Type, "text/css");
            writer.RenderBeginTag(HtmlTextWriterTag.Style);
            writer.WriteLine(@"table#border {
            width: 90%;
            border-width: 1px;
            border-style: solid;
            border-color: lightgray;
        }

        table#header {
            width: 100%;
            height: 100px;
            border-width: 1px;
            border-style: solid;
            border-color: cornflowerblue;
            font-family: Verdana;
        }

        table#body {
            width: 100%;
            border-width: 1px;
            border-style: solid;
            border-color: cornflowerblue;
            font-family: Verdana;
        }

        td#title {
            font-size: 36px;
            background-color: cornflowerblue;
            color: white;
        }

        tr#subtitle {
            font-size: 12px;
        }

        table#footer {
            width: 100%;
            height: 50px;
            border-width: 1px;
            border-style: solid;
            border-color: cornflowerblue;
            font-family: Verdana;
        }

        tr#results {
            font-size: 14px;
        }

        td#grade {
            border: 1px solid dodgerblue;
            width: 125px;
        }

        td#range {
            border: 1px solid dodgerblue;
            width: 125px;
        }

        td#remarks {
            border: 1px solid dodgerblue;
            width: 125px;
        }

        tr.activities {
            font-size: 12px;
        }

        tr#activitytitle {
            height: 30px;
            background-color: cornflowerblue;
        }

        td.type {
            width: 25%;
        }

        td.description {
            width: 25%;
        }

        td.score {
            width: 10%;
            text-align: center;
        }

        td.maxscore {
            width: 10%;
            text-align: center;
        }

        td.average {
            text-align: center;
            font-size: 14px;
            border-top: 3px ridge blue;
            border-bottom: 3px inset blue;
        }

        td.details {
            text-align: center;
            font-size: 14px;
            border-top: 2px solid dodgerblue;
            border-bottom: 2px solid dodgerblue;
            background-color: lightblue;
        }");
            // </style>
            writer.RenderEndTag();
            // </head>
            writer.RenderEndTag();
            writer.WriteLine();
            // <body>
            writer.RenderBeginTag(HtmlTextWriterTag.Body);
            // <table>
            writer.AddAttribute(HtmlTextWriterAttribute.Id, "border");
            writer.AddAttribute(HtmlTextWriterAttribute.Align, "center");
            writer.RenderBeginTag(HtmlTextWriterTag.Table);
            // <tr>
            writer.RenderBeginTag(HtmlTextWriterTag.Tr);
            // <td>
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            // <table>
            writer.AddAttribute(HtmlTextWriterAttribute.Id, "header");
            writer.AddAttribute(HtmlTextWriterAttribute.Align, "center");
            writer.RenderBeginTag(HtmlTextWriterTag.Table);
            // <tr>
            writer.RenderBeginTag(HtmlTextWriterTag.Tr);
            // <td>
            writer.AddAttribute(HtmlTextWriterAttribute.Id, "title");
            writer.AddAttribute(HtmlTextWriterAttribute.Align, "center");
            writer.AddAttribute(HtmlTextWriterAttribute.Colspan, "6");
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            writer.Write(ProjResource.ProjectTitle);
            // </td>
            writer.RenderEndTag();
            // </tr>
            writer.RenderEndTag();
            // <tr>
            writer.AddAttribute(HtmlTextWriterAttribute.Id, "subtitle");
            writer.RenderBeginTag(HtmlTextWriterTag.Tr);
            // <td>
            writer.AddAttribute(HtmlTextWriterAttribute.Width, "50px");
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            writer.Write("Name:");
            // </td>
            writer.RenderEndTag();
            // <td>
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            writer.Write(Globals.Report.Name);
            // </td>
            writer.RenderEndTag();
            // <td>
            writer.AddAttribute(HtmlTextWriterAttribute.Width, "125px");
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            writer.Write("Subject/Section:");
            // </td>
            writer.RenderEndTag();
            // <td>
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            writer.Write(Globals.Report.Section);
            // </td>
            writer.RenderEndTag();
            // <td>
            writer.AddAttribute(HtmlTextWriterAttribute.Width, "50px");
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            writer.Write("Period:");
            // </td>
            writer.RenderEndTag();
            // <td>
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            writer.Write(Globals.Report.Period);
            // </td>
            writer.RenderEndTag();
            // </tr>
            writer.RenderEndTag();
            // </table>
            writer.RenderEndTag();
            // </td>
            writer.RenderEndTag();
            // </tr>
            writer.RenderEndTag();

            //
            //
            // -----------------------------
            //
            //
            // <tr>
            writer.RenderBeginTag(HtmlTextWriterTag.Tr);
            // <td>
            writer.RenderBeginTag(HtmlTextWriterTag.Td);

            for (int x = 0; x < activityList.Items.Count; x++)
            {
                string pivottype1 = activityList.Items[x].SubItems[0].Text;
                // <table>
                writer.AddAttribute(HtmlTextWriterAttribute.Id, "body");
                writer.AddAttribute(HtmlTextWriterAttribute.Align, "center");
                writer.RenderBeginTag(HtmlTextWriterTag.Table);
                // <tr>
                writer.AddAttribute(HtmlTextWriterAttribute.Id, "activitytitle");
                writer.RenderBeginTag(HtmlTextWriterTag.Tr);
                // <th>
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "activitytitle");
                writer.AddAttribute(HtmlTextWriterAttribute.Width, "75%");
                writer.AddAttribute(HtmlTextWriterAttribute.Colspan, "4");
                writer.RenderBeginTag(HtmlTextWriterTag.Th);
                writer.Write(string.Concat(activityList.Items[x].SubItems[0].Text, " (", activityList.Items[x].SubItems[1].Text, "%)"));
                // </th>
                writer.RenderEndTag();
                // <th>
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "activitytitle");
                writer.AddAttribute(HtmlTextWriterAttribute.Width, "25%");
                writer.RenderBeginTag(HtmlTextWriterTag.Th);
                writer.Write("Average");
                // </th>
                writer.RenderEndTag();
                // </tr>
                writer.RenderEndTag();
                // --------------------------------// --------------------------------
                // <tr>
                writer.RenderBeginTag(HtmlTextWriterTag.Tr);
                // <td>
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "details");
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                writer.Write("Type");
                // </td>
                writer.RenderEndTag();
                // <td>
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "details");
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                writer.Write("Description");
                // </td>
                writer.RenderEndTag();
                // <td>
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "details");
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                writer.Write("Score");
                // </td>
                writer.RenderEndTag();
                // <td>
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "details");
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                writer.Write("Max Score");
                // </td>
                writer.RenderEndTag();
                // <td>
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                // </td>
                writer.RenderEndTag();
                // </tr>
                writer.RenderEndTag();
                // --------------------------------// --------------------------------
                for (int y = 0; y < entriesList.Items.Count; y++)
                {
                    string name = entriesList.Items[y].SubItems[0].Text;
                    string pivottype2 = entriesList.Items[y].SubItems[2].Text;
                    string description = entriesList.Items[y].SubItems[3].Text;
                    int score = Convert.ToInt32(entriesList.Items[y].SubItems[4].Text);
                    int maxscore = Convert.ToInt32(entriesList.Items[y].SubItems[5].Text);
                    if (pivottype1.Equals(pivottype2) && name.Equals(Globals.Report.Name))
                    {
                        // <tr>
                        writer.AddAttribute(HtmlTextWriterAttribute.Class, "activities");
                        writer.RenderBeginTag(HtmlTextWriterTag.Tr);
                        // <td>
                        writer.AddAttribute(HtmlTextWriterAttribute.Class, "type");
                        writer.RenderBeginTag(HtmlTextWriterTag.Td);
                        writer.Write(pivottype2);
                        // </td>
                        writer.RenderEndTag();
                        // <td>
                        writer.AddAttribute(HtmlTextWriterAttribute.Class, "description");
                        writer.RenderBeginTag(HtmlTextWriterTag.Td);
                        writer.Write(description);
                        // </td>
                        writer.RenderEndTag();
                        // <td>
                        writer.AddAttribute(HtmlTextWriterAttribute.Class, "score");
                        writer.RenderBeginTag(HtmlTextWriterTag.Td);
                        writer.Write(score);
                        // </td>
                        writer.RenderEndTag();
                        // <td>
                        writer.AddAttribute(HtmlTextWriterAttribute.Class, "maxscore");
                        writer.RenderBeginTag(HtmlTextWriterTag.Td);
                        writer.Write(maxscore);
                        // </td>
                        writer.RenderEndTag();
                        // <td>
                        writer.RenderBeginTag(HtmlTextWriterTag.Td);
                        // </td>
                        writer.RenderEndTag();
                    }
                }
                // --------------------------------// --------------------------------
                // <tr>
                writer.RenderBeginTag(HtmlTextWriterTag.Tr);
                // <td>
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                // </td>
                writer.RenderEndTag();
                // <td>
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                // </td>
                writer.RenderEndTag();
                // <td>
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "average");
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                writer.Write(compute.getTotalScore(Globals.Report.Name, pivottype1, entriesList));
                // </td>
                writer.RenderEndTag();
                // <td>
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "average");
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                writer.Write(compute.getTotalScoreItems(Globals.Report.Name, pivottype1, entriesList));
                // </td>
                writer.RenderEndTag();
                // <td>
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "average");
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                writer.Write(compute.getWeightedAverage(Globals.Report.Name, pivottype1, entriesList, activityList));
                // </td>
                writer.RenderEndTag();
                // </tr>
                writer.RenderEndTag();
                // --------------------------------// --------------------------------
                // </table>
                writer.RenderEndTag();
            }

            // </td>
            writer.RenderEndTag();
            // </tr>
            writer.RenderEndTag();
            //
            //
            // -----------------------------
            //
            //

            // <tr>
            writer.RenderBeginTag(HtmlTextWriterTag.Tr);
            // <td>
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            // <table>
            writer.AddAttribute(HtmlTextWriterAttribute.Id, "footer");
            writer.AddAttribute(HtmlTextWriterAttribute.Align, "center");
            writer.RenderBeginTag(HtmlTextWriterTag.Table);
            // <tr>
            writer.AddAttribute(HtmlTextWriterAttribute.Id, "results");
            writer.RenderBeginTag(HtmlTextWriterTag.Tr);
            // <td>
            writer.AddAttribute(HtmlTextWriterAttribute.Align, "right");
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            writer.Write("Grade:");
            // </td>
            writer.RenderEndTag();
            // <td>
            writer.AddAttribute(HtmlTextWriterAttribute.Id, "grade");
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            writer.Write(Globals.Report.Gpa);
            // </td>
            writer.RenderEndTag();
            // <td>
            writer.AddAttribute(HtmlTextWriterAttribute.Align, "right");
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            writer.Write("Range");
            // </td>
            writer.RenderEndTag();
            // <td>
            writer.AddAttribute(HtmlTextWriterAttribute.Id, "range");
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            writer.Write(Globals.Report.Gwa);
            // </td>
            // <td>
            writer.AddAttribute(HtmlTextWriterAttribute.Align, "right");
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            writer.Write("Remarks");
            // </td>
            writer.RenderEndTag();
            // <td>
            writer.AddAttribute(HtmlTextWriterAttribute.Id, "remarks");
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            writer.Write(Globals.Report.Remarks);
            // </td>
            writer.RenderEndTag();
            // </tr>
            writer.RenderEndTag();
            // </table>
            writer.RenderEndTag();
            // </td>
            writer.RenderEndTag();
            // </tr>
            writer.RenderEndTag();
            // </table>
            writer.RenderEndTag();

            // </body>
            writer.RenderEndTag();

            // </html>
            writer.RenderEndTag();

            return strBldr.ToString();
        }

        /// <summary>
        /// Simple HTML Template
        /// </summary>
        /// <param name="activityList"></param>
        /// <param name="entriesList"></param>
        /// <returns></returns>
        public static string Simple(ListView activityList, ListView entriesList)
        {
            StringBuilder strBldr = new StringBuilder();
            StringWriter strWriter = new StringWriter(strBldr);

            HtmlTextWriter writer = new HtmlTextWriter(strWriter);

            // DOCTYPE
            writer.WriteLine("<!DOCTYPE html>" + "\n");
            //<html>
            writer.RenderBeginTag(HtmlTextWriterTag.Html);
            // <head>
            writer.RenderBeginTag(HtmlTextWriterTag.Head);
            // <title>
            writer.RenderBeginTag(HtmlTextWriterTag.Title);
            writer.Write(ProjResource.ProjectTitle);
            // </title>
            writer.RenderEndTag();
            writer.WriteLine();

            // <style>
            writer.AddAttribute(HtmlTextWriterAttribute.Type, "text/css");
            writer.RenderBeginTag(HtmlTextWriterTag.Style);
            writer.WriteLine(@"table#border{
            width:90%;
            border-width:1px;
            border-style:solid;
            border-color:lightgray;
        }
        table#header{
            width:100%;
            height:100px;
            border-width:1px;
            border-style:solid;
            border-color:black;
            font-family:Verdana;
        }
        table#body{
            width:100%;
            border-width:1px;
            border-style:solid;
            border-color:black;
            font-family:Verdana;
        }
        td#title{
            font-size:36px;
            background-color:dimgray;
            color:white;
        }
        tr#subtitle{
            font-size:12px;
        }
        table#footer{
            width:100%;
            height:50px;
            border-width:1px;
            border-style:solid;
            border-color:black;
            font-family:Verdana;
        }
        tr#results{
            font-size:14px;
        }
        td#grade{
            border:1px solid black;
            width:125px;
        }
        td#range{
            border:1px solid black;
            width:125px;
        }
        td#remarks{
            border:1px solid black;
            width:125px;
        }
        tr.activities{
            font-size:12px;
        }
        tr#activitytitle{
            height:30px;
            background-color:lightgray;
        }
        td.type{
            width:25%;
        }
        td.description{
            width:25%;
        }
        td.score{
            width:10%;
            text-align:center;
        }
        td.maxscore{
            width:10%;
            text-align:center;
        }
        td.average{
            text-align:center;
            font-size:14px;
            border-top:3px ridge red;
            border-bottom:3px inset red;
        }
        td.details{
            text-align:center;
            font-size:14px;
            border-top:2px solid dimgray;
            border-bottom:2px solid dimgray;
            background-color:lightgray;
        }");
            // </style>
            writer.RenderEndTag();
            // </head>
            writer.RenderEndTag();
            writer.WriteLine();
            // <body>
            writer.RenderBeginTag(HtmlTextWriterTag.Body);
            // <table>
            writer.AddAttribute(HtmlTextWriterAttribute.Id, "border");
            writer.AddAttribute(HtmlTextWriterAttribute.Align, "center");
            writer.RenderBeginTag(HtmlTextWriterTag.Table);
            // <tr>
            writer.RenderBeginTag(HtmlTextWriterTag.Tr);
            // <td>
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            // <table>
            writer.AddAttribute(HtmlTextWriterAttribute.Id, "header");
            writer.AddAttribute(HtmlTextWriterAttribute.Align, "center");
            writer.RenderBeginTag(HtmlTextWriterTag.Table);
            // <tr>
            writer.RenderBeginTag(HtmlTextWriterTag.Tr);
            // <td>
            writer.AddAttribute(HtmlTextWriterAttribute.Id, "title");
            writer.AddAttribute(HtmlTextWriterAttribute.Align, "center");
            writer.AddAttribute(HtmlTextWriterAttribute.Colspan, "6");
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            writer.Write(ProjResource.ProjectTitle);
            // </td>
            writer.RenderEndTag();
            // </tr>
            writer.RenderEndTag();
            // <tr>
            writer.AddAttribute(HtmlTextWriterAttribute.Id, "subtitle");
            writer.RenderBeginTag(HtmlTextWriterTag.Tr);
            // <td>
            writer.AddAttribute(HtmlTextWriterAttribute.Width, "50px");
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            writer.Write("Name:");
            // </td>
            writer.RenderEndTag();
            // <td>
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            writer.Write(Globals.Report.Name);
            // </td>
            writer.RenderEndTag();
            // <td>
            writer.AddAttribute(HtmlTextWriterAttribute.Width, "125px");
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            writer.Write("Subject/Section:");
            // </td>
            writer.RenderEndTag();
            // <td>
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            writer.Write(Globals.Report.Section);
            // </td>
            writer.RenderEndTag();
            // <td>
            writer.AddAttribute(HtmlTextWriterAttribute.Width, "50px");
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            writer.Write("Period:");
            // </td>
            writer.RenderEndTag();
            // <td>
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            writer.Write(Globals.Report.Period);
            // </td>
            writer.RenderEndTag();
            // </tr>
            writer.RenderEndTag();
            // </table>
            writer.RenderEndTag();
            // </td>
            writer.RenderEndTag();
            // </tr>
            writer.RenderEndTag();

            //
            //
            // -----------------------------
            //
            //
            // <tr>
            writer.RenderBeginTag(HtmlTextWriterTag.Tr);
            // <td>
            writer.RenderBeginTag(HtmlTextWriterTag.Td);

            for (int x = 0; x < activityList.Items.Count; x++)
            {
                string pivottype1 = activityList.Items[x].SubItems[0].Text;
                // <table>
                writer.AddAttribute(HtmlTextWriterAttribute.Id, "body");
                writer.AddAttribute(HtmlTextWriterAttribute.Align, "center");
                writer.RenderBeginTag(HtmlTextWriterTag.Table);
                // <tr>
                writer.AddAttribute(HtmlTextWriterAttribute.Id, "activitytitle");
                writer.RenderBeginTag(HtmlTextWriterTag.Tr);
                // <th>
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "activitytitle");
                writer.AddAttribute(HtmlTextWriterAttribute.Width, "75%");
                writer.AddAttribute(HtmlTextWriterAttribute.Colspan, "4");
                writer.RenderBeginTag(HtmlTextWriterTag.Th);
                writer.Write(string.Concat(activityList.Items[x].SubItems[0].Text, " (", activityList.Items[x].SubItems[1].Text, "%)"));
                // </th>
                writer.RenderEndTag();
                // <th>
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "activitytitle");
                writer.AddAttribute(HtmlTextWriterAttribute.Width, "25%");
                writer.RenderBeginTag(HtmlTextWriterTag.Th);
                writer.Write("Average");
                // </th>
                writer.RenderEndTag();
                // </tr>
                writer.RenderEndTag();
                // --------------------------------// --------------------------------
                // <tr>
                writer.RenderBeginTag(HtmlTextWriterTag.Tr);
                // <td>
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "details");
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                writer.Write("Type");
                // </td>
                writer.RenderEndTag();
                // <td>
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "details");
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                writer.Write("Description");
                // </td>
                writer.RenderEndTag();
                // <td>
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "details");
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                writer.Write("Score");
                // </td>
                writer.RenderEndTag();
                // <td>
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "details");
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                writer.Write("Max Score");
                // </td>
                writer.RenderEndTag();
                // <td>
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                // </td>
                writer.RenderEndTag();
                // </tr>
                writer.RenderEndTag();
                // --------------------------------// --------------------------------
                for (int y = 0; y < entriesList.Items.Count; y++)
                {
                    string name = entriesList.Items[y].SubItems[0].Text;
                    string pivottype2 = entriesList.Items[y].SubItems[2].Text;
                    string description = entriesList.Items[y].SubItems[3].Text;
                    int score = Convert.ToInt32(entriesList.Items[y].SubItems[4].Text);
                    int maxscore = Convert.ToInt32(entriesList.Items[y].SubItems[5].Text);
                    if (pivottype1.Equals(pivottype2) && name.Equals(Globals.Report.Name))
                    {
                        // <tr>
                        writer.AddAttribute(HtmlTextWriterAttribute.Class, "activities");
                        writer.RenderBeginTag(HtmlTextWriterTag.Tr);
                        // <td>
                        writer.AddAttribute(HtmlTextWriterAttribute.Class, "type");
                        writer.RenderBeginTag(HtmlTextWriterTag.Td);
                        writer.Write(pivottype2);
                        // </td>
                        writer.RenderEndTag();
                        // <td>
                        writer.AddAttribute(HtmlTextWriterAttribute.Class, "description");
                        writer.RenderBeginTag(HtmlTextWriterTag.Td);
                        writer.Write(description);
                        // </td>
                        writer.RenderEndTag();
                        // <td>
                        writer.AddAttribute(HtmlTextWriterAttribute.Class, "score");
                        writer.RenderBeginTag(HtmlTextWriterTag.Td);
                        writer.Write(score);
                        // </td>
                        writer.RenderEndTag();
                        // <td>
                        writer.AddAttribute(HtmlTextWriterAttribute.Class, "maxscore");
                        writer.RenderBeginTag(HtmlTextWriterTag.Td);
                        writer.Write(maxscore);
                        // </td>
                        writer.RenderEndTag();
                        // <td>
                        writer.RenderBeginTag(HtmlTextWriterTag.Td);
                        // </td>
                        writer.RenderEndTag();
                    }
                }
                // --------------------------------// --------------------------------
                // <tr>
                writer.RenderBeginTag(HtmlTextWriterTag.Tr);
                // <td>
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                // </td>
                writer.RenderEndTag();
                // <td>
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                // </td>
                writer.RenderEndTag();
                // <td>
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "average");
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                writer.Write(compute.getTotalScore(Globals.Report.Name, pivottype1, entriesList));
                // </td>
                writer.RenderEndTag();
                // <td>
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "average");
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                writer.Write(compute.getTotalScoreItems(Globals.Report.Name, pivottype1, entriesList));
                // </td>
                writer.RenderEndTag();
                // <td>
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "average");
                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                writer.Write(compute.getWeightedAverage(Globals.Report.Name, pivottype1, entriesList, activityList));
                // </td>
                writer.RenderEndTag();
                // </tr>
                writer.RenderEndTag();
                // --------------------------------// --------------------------------
                // </table>
                writer.RenderEndTag();
            }

            // </td>
            writer.RenderEndTag();
            // </tr>
            writer.RenderEndTag();
            //
            //
            // -----------------------------
            //
            //

            // <tr>
            writer.RenderBeginTag(HtmlTextWriterTag.Tr);
            // <td>
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            // <table>
            writer.AddAttribute(HtmlTextWriterAttribute.Id, "footer");
            writer.AddAttribute(HtmlTextWriterAttribute.Align, "center");
            writer.RenderBeginTag(HtmlTextWriterTag.Table);
            // <tr>
            writer.AddAttribute(HtmlTextWriterAttribute.Id, "results");
            writer.RenderBeginTag(HtmlTextWriterTag.Tr);
            // <td>
            writer.AddAttribute(HtmlTextWriterAttribute.Align, "right");
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            writer.Write("Grade:");
            // </td>
            writer.RenderEndTag();
            // <td>
            writer.AddAttribute(HtmlTextWriterAttribute.Id, "grade");
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            writer.Write(Globals.Report.Gpa);
            // </td>
            writer.RenderEndTag();
            // <td>
            writer.AddAttribute(HtmlTextWriterAttribute.Align, "right");
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            writer.Write("Range");
            // </td>
            writer.RenderEndTag();
            // <td>
            writer.AddAttribute(HtmlTextWriterAttribute.Id, "range");
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            writer.Write(Globals.Report.Gwa);
            // </td>
            // <td>
            writer.AddAttribute(HtmlTextWriterAttribute.Align, "right");
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            writer.Write("Remarks");
            // </td>
            writer.RenderEndTag();
            // <td>
            writer.AddAttribute(HtmlTextWriterAttribute.Id, "remarks");
            writer.RenderBeginTag(HtmlTextWriterTag.Td);
            writer.Write(Globals.Report.Remarks);
            // </td>
            writer.RenderEndTag();
            // </tr>
            writer.RenderEndTag();
            // </table>
            writer.RenderEndTag();
            // </td>
            writer.RenderEndTag();
            // </tr>
            writer.RenderEndTag();
            // </table>
            writer.RenderEndTag();

            // </body>
            writer.RenderEndTag();

            // </html>
            writer.RenderEndTag();

            return strBldr.ToString();
        }
    }
}
