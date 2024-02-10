public class WeaknessCalculator 
{
    public static int DamageToDeal(SO_Enemy.TYPE damageDealer,SO_Enemy.TYPE damageTaker, int level)
    {
        int damageToDeal;

        switch(damageDealer, damageTaker)
        {
            default:
                damageToDeal = 2;
                break;

            case (SO_Enemy.TYPE.FIRE, SO_Enemy.TYPE.WATER):
                damageToDeal = 1;
                break;
            case (SO_Enemy.TYPE.FIRE, SO_Enemy.TYPE.FIRE):
                damageToDeal = 2;
                break;
            case (SO_Enemy.TYPE.FIRE, SO_Enemy.TYPE.GRASS):
                damageToDeal = 4;
                break;
            
            case (SO_Enemy.TYPE.WATER, SO_Enemy.TYPE.WATER):
                damageToDeal = 2;
                break;
            case (SO_Enemy.TYPE.WATER, SO_Enemy.TYPE.FIRE):
                damageToDeal = 4;
                break;
            case (SO_Enemy.TYPE.WATER, SO_Enemy.TYPE.GRASS):
                damageToDeal = 1;
                break;
            
            case (SO_Enemy.TYPE.GRASS, SO_Enemy.TYPE.WATER):
                damageToDeal = 4;
                break;
            case (SO_Enemy.TYPE.GRASS, SO_Enemy.TYPE.FIRE):
                damageToDeal = 1;
                break;
            case (SO_Enemy.TYPE.GRASS, SO_Enemy.TYPE.GRASS):
                damageToDeal = 2;
                break;
        }
        return damageToDeal * level;
    }
}
