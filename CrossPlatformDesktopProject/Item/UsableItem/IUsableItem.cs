using System;
namespace Sprint2
{
    public interface IUsableItem : IItem
    {

        void UseLeft();

        void UseRight();

        void UseDown();

        void UseUp();

    }
}
