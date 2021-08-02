namespace FacadePattern.Sample1
{
    public class EncrytFacade
    {
        private readonly FileReader _reader = new();
        private readonly CipherMachine _cipher = new();
        private readonly FileWriter _writer = new();

        public void FileEncrypt(string fileNameSrc, string fileNameDes)
        {
            var plainStr = _reader.Read(fileNameSrc);
            var encryptStr = _cipher.Encrypt(plainStr);
            _writer.Write(encryptStr, fileNameDes);
        }
    }
}