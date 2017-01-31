using System;
using System.Collections.Generic;
using System.Text;

namespace TVSanguosha
{
    /// <summary>
    /// 牌堆
    /// </summary>
    public class CardHeap
    {
        private List<Card> list;
        /// <summary>
        /// 牌堆的牌的数量
        /// </summary>
        public int Count
        {
            get
            {
                return this.list.Count;
            }
        }
        /// <summary>
        /// 向牌堆中压入指定的牌组。
        /// </summary>
        /// <param name="cards">被压入的牌的数组</param>
        public void Push(Card[] cards)
        {
            foreach(Card card in cards)
            {
                this.list.Add(card);
            }
        }
        /// <summary>
        /// 从牌堆中压出指定数量的牌，这些牌将会从牌堆中移除。
        /// </summary>
        /// <param name="number">要压出的牌的数量。</param>
        /// <returns>所压出的牌的数组。</returns>
        public Card[] Pop(int number=1)
        {
            if(number<=0)
            {
                return new Card[0];
            }

            if(number>this.list.Count)
            {
                number = this.list.Count;
            }

            Card[] cards = new Card[number];

            for(int i=0;i<number;i++)
            {
                cards[i] = this.list[this.list.Count - 1];
                this.list.RemoveAt(this.list.Count - 1);
            }

            return cards;
        }
        /// <summary>
        /// 对牌堆进行洗牌。
        /// </summary>
        public void Shuffle()
        {
            Random r = new Random();
            int count = this.list.Count;
            for (int i = 0; i < count; i++)
            {
                int currentIndex = r.Next(0, count - i);
                Card tempCard = this.list[currentIndex];
                this.list[currentIndex] = this.list[count - 1 - i];
                this.list[count - 1 - i] = tempCard;
            }
        }
    }
}
