﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Trojan_Travels.Models;

public partial class Reward
{
    [Key]
    public int RewardId { get; set; }

    [StringLength(50)]
    public string? RwdName { get; set; }

    [StringLength(50)]
    public string? RwdDesc { get; set; }

    [InverseProperty("Reward")]
    public virtual ICollection<CustomersReward> CustomersRewards { get; set; } = new List<CustomersReward>();
}
