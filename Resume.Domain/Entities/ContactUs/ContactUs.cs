﻿using System.Security.Cryptography;

namespace Resume.Domain.Entities.ContactUs;

public class ContactUs
{
    #region properties

    public int Id { get; set; }

    public string FullName { get; set; }

    public string Mobile { get; set; }

    public string Message { get; set; }

    public DateTime CreateDate { get; set; }

    public bool IsSeenByAdmin { get; set; }

    #endregion
}
