﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SwashbuckleODataSample.Models
{
  public class ToolHistory
  {
    [Key]
    public int ID { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
  }
}