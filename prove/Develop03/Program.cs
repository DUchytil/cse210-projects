/*
ABOVE AND BEYOND: I added functionality to hide only words that haven't already been hidden.
I also added a large list of scriptures to choose from. They are randomly selected when the program starts.
*/

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> _scriptureList = new List<Scripture>();
        _scriptureList.Add(new Scripture(new Reference("John", 3, 5, 6), "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God. That which is born of the flesh is flesh; and that which is born of the Spirit is spirit."));
        _scriptureList.Add(new Scripture(new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."));
        _scriptureList.Add(new Scripture(new Reference("Mosiah", 2, 17), "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God."));
        _scriptureList.Add(new Scripture(new Reference("Alma", 32, 21), "And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true."));
        _scriptureList.Add(new Scripture(new Reference("Ether", 12, 27), "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them."));
        _scriptureList.Add(new Scripture(new Reference("2 Nephi", 2, 25, 27), "Adam fell that men might be; and men are, that they might have joy. And the Messiah cometh in the fulness of time, that he may redeem the children of men from the fall. And because that they are redeemed from the fall they have become free forever, knowing good from evil; to act for themselves and not to be acted upon, save it be by the punishment of the law at the great and last day, according to the commandments which God hath given. Wherefore, men are free according to the flesh; and all things are given them which are expedient unto man. And they are free to choose liberty and eternal life, through the great Mediator of all men, or to choose captivity and death, according to the captivity and power of the devil; for he seeketh that all men might be miserable like unto himself."));
        _scriptureList.Add(new Scripture(new Reference("Enos", 1, 2, 4), "And I will tell you of the wrestle which I had before God, before I received a remission of my sins. Behold, I went to hunt beasts in the forests; and the words which I had often heard my father speak concerning eternal life, and the joy of the saints, sunk deep into my heart. And my soul hungered; and I kneeled down before my Maker, and I cried unto him in mighty prayer and supplication for mine own soul; and all the day long did I cry unto him; yea, and when the night came I did still raise my voice high that it reached the heavens."));
        _scriptureList.Add(new Scripture(new Reference("Alma", 37, 35, 37), "O, remember, my son, and learn wisdom in thy youth; yea, learn in thy youth to keep the commandments of God. Yea, and cry unto God for all thy support; yea, let all thy doings be unto the Lord, and whithersoever thou goest let it be in the Lord; yea, let all thy thoughts be directed unto the Lord; yea, let the affections of thy heart be placed upon the Lord forever. Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day."));
        _scriptureList.Add(new Scripture(new Reference("Helaman", 5, 12), "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall."));
        _scriptureList.Add(new Scripture(new Reference("3 Nephi", 11, 29, 30), "For verily, verily I say unto you, he that hath the spirit of contention is not of me, but is of the devil, who is the father of contention, and he stirreth up the hearts of men to contend with anger, one with another. Behold, this is not my doctrine, to stir up the hearts of men with anger, one against another; but this is my doctrine, that such things should be done away."));
        _scriptureList.Add(new Scripture(new Reference("Moroni", 10, 4, 5), "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things."));
        _scriptureList.Add(new Scripture(new Reference("Mosiah", 4, 9), "Believe in God; believe that he is, and that he created all things, both in heaven and in earth; believe that he has all wisdom, and all power, both in heaven and in earth; believe that man doth not comprehend all the things which the Lord can comprehend."));
        _scriptureList.Add(new Scripture(new Reference("Jacob", 2, 17, 19), "Think of your brethren like unto yourselves, and be familiar with all and free with your substance, that they may be rich like unto you. But before ye seek for riches, seek ye for the kingdom of God. And after ye have obtained a hope in Christ ye shall obtain riches, if ye seek them; and ye will seek them for the intent to do good—to clothe the naked, and to feed the hungry, and to liberate the captive, and administer relief to the sick and the afflicted."));

        Random rn = new Random();

        Scripture scripture = _scriptureList[rn.Next(_scriptureList.Count)];


        bool quit = false;
        while (!quit)
        {

            if (scripture.AllWordsHidden())
            {
                break;
            }

            Console.Clear();

            scripture.DisplayScripture();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type quit to finish: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                quit = true;
            }

            scripture.HideRandomWords();

        }


    }

}

