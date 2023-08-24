using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace use_case_23.Classes.Enums {
  internal enum Role {
    Director,
    Producer,
    Screenwriter,
    Actor,
    Actress,
    Cinematographer,
    [Display(Name ="Film Editor")]
    FilmEditor,
    [Display(Name = "Production Designer")]
    ProductionDesigner,
    [Display(Name = "Costume Designer")]
    CostumeDesigner,
    [Display(Name = " Music Composer")]
    MusicComposer
  }
}
