using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Trojan_Travels.Models;

public partial class Package
{
    // Parameterless constructor (default constructor)
    public Package()
    {
    }

    // Constructor with parameters that match property names
    public Package(string pkgName, DateTime pkgStartDate, DateTime pkgEndDate, string pkgDesc, decimal pkgBasePrice, decimal pkgAgencyCommission)
    {
        PkgName = pkgName;
        PkgStartDate = pkgStartDate;
        PkgEndDate = pkgEndDate;
        PkgDesc = pkgDesc;
        PkgBasePrice = pkgBasePrice;
        PkgAgencyCommission = pkgAgencyCommission;
    }
    [Key]
    public int PackageId { get; set; }

    [StringLength(50)]
    public string PkgName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? PkgStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PkgEndDate { get; set; }

    [StringLength(50)]
    public string? PkgDesc { get; set; }

    [Column(TypeName = "money")]
    public decimal PkgBasePrice { get; set; }

    [Column(TypeName = "money")]
    public decimal? PkgAgencyCommission { get; set; }

    [InverseProperty("Package")]
    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    [InverseProperty("Package")]
    public virtual ICollection<PackagesProductsSupplier> PackagesProductsSuppliers { get; set; } = new List<PackagesProductsSupplier>();
}
