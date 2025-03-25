namespace UnitTestsLibrary{

    public class Alumno {

        private INotasService _notasService;

        public int Id {get;set;}
        public string Nombre {get;set;}
        public string Apellido {get;set;}

        public Alumno(INotasService notasService){
            Id = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            this._notasService = notasService;
        }        

        public int ObtenerMediaNotas() {
            var notas = this._notasService.ObtenerNotas(this.Id);
            
            return (int)notas.Average();
        }

    }
}