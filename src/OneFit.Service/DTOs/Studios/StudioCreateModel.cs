﻿using OneFit.Domain.Enums;

namespace OneFit.Service.DTOs.Studios;

public class StudioCreateModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Address { get; set; }
    public StudioType Type { get; set; }
    public long CategoryId { get; set; }
}