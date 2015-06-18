namespace DocumentSystem
{
    using System;
    using System.Collections.Generic;

    public abstract class OfficeDocument : BinaryDocument, IEncryptable
    {
        private bool isEncrypted = false;

        public string Version { get; set; }
      
        public override void LoadProperty(string key, string value)
        {
            if (key == "version")
            {
                this.Version = value;
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("version", this.Version));
        }

        public bool IsEncrypted
        {
            get { return this.isEncrypted; }
        }

        public void Encrypt()
        {
            this.isEncrypted = true;
        }

        public void Decrypt()
        {
            this.isEncrypted = false;
        }

        public override string ToString()
        {
            if (this.isEncrypted)
            {
                return String.Format("{0}[encrypted]", this.GetType().Name);
            }
            else
            {
                return base.ToString();
            }
        }
    }
}
