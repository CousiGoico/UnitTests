
namespace UnitTestsLibrary
{

    public class NotasService : INotasService
    {
        public List<int> ObtenerNotas(int idAlumno) {
            return new List<int>(){ 6, 8, 6, 8 };
        }
    }
}