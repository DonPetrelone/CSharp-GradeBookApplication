using GradeBook.Enums;

namespace GradeBooks.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradebook(string name) : base(name)
        {
            Type = GradeBookType.Standard;
            
        }
    }
}