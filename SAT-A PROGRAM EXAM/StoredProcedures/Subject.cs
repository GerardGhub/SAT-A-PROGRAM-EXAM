using AutoSproc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT_A_PROGRAM_EXAM.StoredProcedures
{
    public interface Subject : ISprocBase
    {


        DataSet sp_subject(
        int subject_id,
        string subject_description,
        string mode);
    }
}

