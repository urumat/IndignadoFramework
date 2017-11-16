//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template made by Louis-Guillaume Morand.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;

namespace IndignadoFramework.Entities
{
    
    
    public class EspecificacionUsuarioMetaData
    {
    	[Display(Name ="Id")]
        [Required(ErrorMessage="Campo requerido")]
        public virtual int Id { get; set; }
    	
    	[Display(Name ="UbicacionLatitud")]
        [Required(ErrorMessage="Campo requerido")]
        public virtual double UbicacionLatitud { get; set; }
    	
    	[Display(Name ="UbicacionLongitud")]
        [Required(ErrorMessage="Campo requerido")]
        public virtual double UbicacionLongitud { get; set; }
    	
    	[Display(Name ="Membership")]
    	[StringLength(95, ErrorMessage="Debe ingresar menos de 95 caracteres")]
        [Required(ErrorMessage="Campo requerido")]
        public virtual string Membership { get; set; }
    	
    	[Display(Name ="Nombre")]
        [Required(ErrorMessage="Campo requerido")]
        public virtual string Nombre { get; set; }
    	
    	[Display(Name ="MovimientoId")]
        [Required(ErrorMessage="Campo requerido")]
        public virtual int MovimientoId { get; set; }
    	
    	[Display(Name ="BajasContenido")]
        [Required(ErrorMessage="Campo requerido")]
        public virtual int BajasContenido { get; set; }
    	
    }
}