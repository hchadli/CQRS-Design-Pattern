using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Models
{
    public class Result
    {
        private readonly bool _succeeded;
        private readonly IEnumerable<string> _errors;

        public bool Succeeded { get; set; }
        public IEnumerable<string> Errors { get; set; }   // Simple Array

        internal Result(bool succeeded, IEnumerable<string> errors)
        {
            _succeeded = succeeded;
            _errors = errors;
        }

        public static Result Success()
        {
            return new Result(true, new List<string>());
        }

        public static Result Failure(IEnumerable<string> errors)
        {
            return new Result(false, errors);
        }
    }
}
