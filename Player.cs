namespace 용사의_나날
{
    public class Player
    {
        public string userName;
        private int power;
        private int hp;

        public Player(string userName)
        {
            this.userName = userName;
        }

        public Player(string userName, int power, int hp)
        {
            this.userName = userName;
            this.power = power;
            this.hp = hp;
        }
    }
}