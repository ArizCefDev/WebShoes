﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOEntity
{
    public class MarkaClassicDTO
    {
        public int ID { get; set; }
        public string ShoeName { get; set; }
        public bool Status { get; set; }
        public IEnumerable<ShoeClassicDTO> ShoeClassicDTOs { get; set; }
    }
}
