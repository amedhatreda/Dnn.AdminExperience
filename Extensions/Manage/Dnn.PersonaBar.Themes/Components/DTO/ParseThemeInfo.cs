﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Dnn.PersonaBar.Themes.Components.DTO
{
    [DataContract]
    public class ParseThemeInfo
    {
        [DataMember(Name = "themeName")]
        public string ThemeName { get; set; }

        [DataMember(Name = "level")]
        public ThemeLevel Level { get; set; }

        [DataMember(Name = "parseType")]
        public ParseType ParseType { get; set; }
    }
}