﻿using System.ComponentModel.DataAnnotations;

namespace Amido.NAuto.IntegrationTests.Helpers
{
    public class TestAnnotationModel
    {
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.PostalCode)]
        public string PostCode { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [DataType(DataType.Url)]
        public string Url { get; set; }

        [MaxLength(10)]
        public string MaxLengthTest { get; set; }

        [MinLength(500)]
        [MaxLength(1000)]
        public string MinLengthTest { get; set; }

        [MinLength(50)]
        [MaxLength(55)]
        public string MinMaxLengthTest { get; set; }
    }
}