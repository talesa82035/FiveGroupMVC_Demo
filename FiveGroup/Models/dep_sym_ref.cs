//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FiveGroup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(MetadataDepSymRef))]

    public partial class dep_sym_ref
    {
        public long dep_sym_sn { get; set; }
        public string part_id { get; set; }
        public string sym_id { get; set; }
        public string dep_id { get; set; }
    
        public virtual bodypart bodypart { get; set; }
        public virtual department department { get; set; }
        public virtual symptom symptom { get; set; }
    }
}
