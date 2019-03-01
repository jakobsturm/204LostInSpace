using Microsoft.Xna.Framework;

namespace LostInSpaceLib
{
    abstract public class Entity
    {
        abstract public void Update(GameTime gameTime);
        abstract public void Draw(GameTime gameTime);
    }
}
