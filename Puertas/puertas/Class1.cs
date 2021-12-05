namespace puertas
{
    public class Door
    {
        private bool Opend {get;set;}
        private bool Locked {get;set;}
        private string key {get;set;}

        // Constructors
        public Door(){
            Opend = true;
            Locked = false;
        }

        // Getters
        public bool IsOpen(){
            return Opend;
        }
        public bool IsClosed(){
            return !Opend;
        }
        public bool IsLocked(){
            return Locked;
        }
        public bool IsUnlocked(){
            return !Locked;
        }

        // Basic Operations
        public void Close(){
            if (Locked == false && Opend == true)
            {
                Opend = false;
            }
            else
            {
                throw new System.Exception("Cannot pass because it is: closed || locked");
            }
        }
        public void Open(){
            if (Locked == false && Opend == false)
            {
                Opend = true;
            }
            else
            {
                throw new System.Exception("Cannot pass because it is: open || locked");
            }
        }
        public void Lock(string k){
            if (Locked == false)
            {
                Locked = true;
                key = k;
            }
            else
            {
                throw new System.Exception("Cannot pass because it is: locked");
            }
        }
        public void Unlock(string k){
            if (Locked == true && key == k)
            {
                Locked = false;
            }
            else
            {
                throw new System.Exception("Cannot pass because it is: unlocked || Incorrect key");
            }
        }

        // COMPLEX
        public void OpenAndUnlock(string k){
            if (Locked == true && Opend == false && key == k)
            {
                this.Unlock(k);
                this.Open();
            }
            else
            {
                throw new System.Exception("Cannot pass because it is: Unlocked || Incorrect key || Open");
            }
        }
        public void OpenAndLock(string k){
            if (Locked == false && Opend == false)
            {
                this.Open();
                this.Lock(k);
            }
            else
            {
                throw new System.Exception("Cannot pass because it is: Locked || Open");
            }
        }
        public void CloseAndUnlock(string k){
            if (Locked == true && Opend == true && key == k)
            {
                this.Unlock(k);
                this.Close();
            }
            else
            {
                throw new System.Exception("Cannot pass because it is: Unlocked || Incorrect key || Closed");
            }
        }
        public void CloseAndLock(string k){
            if (Locked == false && Opend == true)
            {
                this.Close();
                this.Lock(k);
            }
            else
            {
                throw new System.Exception("Cannot pass because it is: Locked || Closed");
            }
        }
    }
}
