//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZooMarket
{
    using System;
    using System.Collections.Generic;
    
    public partial class Увольнения
    {
        public int УвольнениеID { get; set; }
        public Nullable<int> СотрудникID { get; set; }
        public Nullable<System.DateTime> ДатаУвольнения { get; set; }
        public string Причина { get; set; }
    
        public virtual Сотрудники Сотрудники { get; set; }
        public virtual Сотрудники Сотрудники1 { get; set; }
    }
}
