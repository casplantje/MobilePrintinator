namespace MobilePrintinator
{
    public interface IBufferBuilder
    {
        void Append(byte[] data);
        void Append(char c);
        void Append(byte b);

        byte[] buffer {  get; }
    }
}