using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GSThemes.Theme
{
    public class Simple:Format
    {
        public override string Activities()
        {
            string result = string.Concat(
                "tr.activities{" + "\n",
                "  font-size:12px;" + "\n",
                "}" + "\n");
            return result;
        }
        public override string ActivityTitle()
        {
            string result = string.Concat(
                "tr#activitytitle{" + "\n",
                "  height:30px;" + "\n",
                "  background-color:lightgray;" + "\n",
                "}" + "\n");
            return result;
        }
        public override string Average()
        {
            string result = string.Concat(
                "td.average{" + "\n",
                "  text-align:center;" + "\n",
                "  font-size:14px;" + "\n",
                "  border-top:3px ridge red;" + "\n",
                "  border-bottom:3px inset red;" + "\n",
                "}" + "\n");
            return result;
        }
        public override string Body()
        {
            string result = string.Concat(
                "table#body{" + "\n",
                "  width:100%;" + "\n",
                "  border-width:1px;" + "\n",
                "  border-style:solid;" + "\n",
                "  border-color:black;" + "\n",
                "  font-family:Verdana;" + "\n",
                "}" + "\n");
            return result;
        }
        public override string Border()
        {
            string result = string.Concat(
                "table#border{" + "\n",
                "  width:90%;" + "\n",
                "  border-width:1px;" + "\n",
                "  border-style:solid;" + "\n",
                "  border-color:lightgray;" + "\n",
                "}" + "\n");
            return result;
        }
        public override string Description()
        {
            string result = string.Concat(
                "td.description{" + "\n",
                "  width:25%;" + "\n",
                "}" + "\n");
            return result;
        }
        public override string Details()
        {
            string result = string.Concat(
                "td.details{" + "\n",
                "  text-align:center;" + "\n",
                "  font-size:14px;" + "\n",
                "  border-top:2px solid dimgray;" + "\n",
                "  border-bottom:2px solid dimgray;" + "\n",
                "  background-color:lightgray;" + "\n",
                "}" + "\n");
            return result;
        }
        public override string Footer()
        {
            string result = string.Concat(
                "table#footer{" + "\n",
                "  width:100%;" + "\n",
                "  height:50px;" + "\n",
                "  border-width:1px;" + "\n",
                "  border-style:solid;" + "\n",
                "  border-color:black;" + "\n",
                "  font-family:Verdana;" + "\n",
                "}" + "\n");
            return result;
        }
        public override string Grade()
        {
            string result = string.Concat(
                "td#grade{" + "\n",
                "  border:1px solid black;" + "\n",
                "  width:125px;" + "\n",
                "}" + "\n");
            return result;
        }
        public override string Header()
        {
            string result = string.Concat(
                "table#header{" + "\n",
                "  width:100%;" + "\n",
                "  height:100px;" + "\n",
                "  border-width:1px;" + "\n",
                "  border-style:solid;" + "\n",
                "  border-color:black;" + "\n",
                "  font-family:Verdana;" + "\n",
                "}" + "\n");
            return result;
        }
        public override string MaxScore()
        {
            string result = string.Concat(
                "td.maxscore{" + "\n",
                "  width:10%;" + "\n",
                "  text-align:center;" + "\n",
                "}" + "\n");
            return result;
        }
        public override string Range()
        {
            string result = string.Concat(
                "td#range{" + "\n",
                "  border:1px solid black;" + "\n",
                "  width:125px;" + "\n",
                "}" + "\n");
            return result;
        }
        public override string Remarks()
        {
            string result = string.Concat(
                "td#remarks{" + "\n",
                "  border:1px solid black;" + "\n",
                "  width:125px;" + "\n",
                "}" + "\n");
            return result;
        }
        public override string Results()
        {
            string result = string.Concat(
                "tr#results{" + "\n",
                "  font-size:14px;" + "\n",
                "}" + "\n");
            return result;
        }
        public override string Score()
        {
            string result = string.Concat(
                "td.score{" + "\n",
                "  width:10%;" + "\n",
                "  text-align:center;" + "\n",
                "}" + "\n");
            return result;
        }
        public override string Subtitle()
        {
            string result = string.Concat(
                "tr#subtitle{" + "\n",
                "  font-size:12px;" + "\n",
                "}" + "\n");
            return result;
        }
        public override string Title()
        {
            string result = string.Concat(
                "td#title{" + "\n",
                "  font-size:36px;" + "\n",
                "  background-color:dimgray;" + "\n",
                "  color:white;" + "\n",
                "}" + "\n");
            return result;
        }
        public override string Type()
        {
            string result = string.Concat(
                "td.type{" + "\n",
                "  width:25%;" + "\n",
                "}" + "\n");
            return result;
        }
    }
}
