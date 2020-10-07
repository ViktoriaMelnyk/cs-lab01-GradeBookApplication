

using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name)
        {
            Type = GradeBookType.Standard;
        }
    }
}
