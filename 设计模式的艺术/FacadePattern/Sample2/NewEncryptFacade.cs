using FacadePattern.Sample1;

namespace FacadePattern.Sample2
{
    /// <summary>
    /// 新加密外观类：具体外观类
    /// </summary>
    public class NewEncryptFacade : AbstractEncryptFacade
    {
        private readonly FileReader _reader = new();
        private readonly NewCipherMachine _cipher = new();
        private readonly FileWriter _writer = new();

        public override void FileEncrypt(string fileNameSrc, string fileNameDes)
        {
            var plainStr = _reader.Read(fileNameSrc);
            var encryptStr = _cipher.Encrypt(plainStr);
            _writer.Write(encryptStr, fileNameDes);
        }
    }
}