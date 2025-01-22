﻿namespace CompanyManager.Logic.Contracts
{
        /// <summary>
        /// Represents a company in the company manager.
        /// </summary>
        public interface ICompany : IIdentifiable
        {
                /// <summary>
                /// Gets or sets the _name of the company.
                /// </summary>
                string Name { get; set; }
                /// <summary>
                /// Gets or sets the address of the company.
                /// </summary>
                string? Address { get; set; }

        }
}
