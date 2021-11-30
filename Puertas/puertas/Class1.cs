namespace puertas
{
    public class Door
    {
        private bool Opend {get;set;}
        private bool Locked {get;set;}
        private string key {get;set;}
        public Door(){
            Opend = true;
            Locked = false;
        }
        public string Close(){
            if (Locked == false || Opend == true)
            {
                Opend = false;
                return "OK";
            }
            else
            {
                return "ERROR";
            }
        }
        public string Open(){
            if (Locked == false && Opend == false)
            {
                Opend = true;
                return "OK";
            }
            else
            {
                return "ERROR";
            }
        }
        public string Lock(string k){
            if (Locked == false)
            {
                Locked = true;
                key = k;
                return "OK";
            }
            else
            {
                return "ERROR";
            }
        }
        public string Unlock(string k){
            if (Locked == true || key == k)
            {
                Locked = false;
                return "OK";
            }
            else
            {
                return "ERROR";
            }
        }

        // COMPLEX
        public string OpenAndUnlock(string k){
            if (Locked == true && Opend == false && key == k)
            {
                this.Unlock(k);
                this.Open();
                return "OK";
            }
            else
            {
                return "ERROR";
            }
        }
        public string OpenAndLock(string k){
            if (Locked == false && Opend == false)
            {
                this.Open();
                this.Lock(k);
                return "OK";
            }
            else
            {
                return "ERROR";
            }
        }
        public string CloseAndUnlock(string k){
            if (Locked == true && Opend == true && key == k)
            {
                this.Unlock(k);
                this.Close();
                return "OK";
            }
            else
            {
                return "ERROR";
            }
        }
        public string CloseAndLock(string k){
            if (Locked == false && Opend == true)
            {
                this.Close();
                this.Lock(k);
                return "OK";
            }
            else
            {
                return "ERROR";
            }
        }
    }
}
