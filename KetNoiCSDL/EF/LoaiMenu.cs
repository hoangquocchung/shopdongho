namespace KetNoiCSDL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiMenu")]
    public partial class LoaiMenu
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}
