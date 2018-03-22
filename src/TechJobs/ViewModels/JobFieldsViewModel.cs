using System;
using System.Collections.Generic;
using TechJobs.Models;

namespace TechJobs.ViewModels
{
    public class JobFieldsViewModel : BaseViewModel
    {
        // TODO #7.2 - Extract members common to SearchJobsViewModel
        // to BaseViewModel

        // All fields in the given column
        public IEnumerable<JobField> Fields { get; set; }

        // The current column
        public JobFieldType Column { get; set; }

        public JobFieldsViewModel()
        { }
    }
}