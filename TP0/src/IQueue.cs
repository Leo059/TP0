namespace TP0{

    public interface IQueue{

        bool IsEmpty { get; }
        int Size { get; }
        void Add(object item);
        object Top { get; }
        void Remove();
    }
}
