using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace plagiarism_detection.Models
{
    public class TextModel
    {
        //[Display(Text = "Text")]
        public string Text { get; set; }

    }
}
