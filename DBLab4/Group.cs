namespace DBLab4
{
    class Group
    {
        public int Id { get; set; }
        public int Number { get; set; }

        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
