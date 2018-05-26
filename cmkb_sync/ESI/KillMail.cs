using System;
using System.Collections.Generic;
using System.Text;

namespace cmkb_sync.ESI
{
    public class Attacker
    {
        public int? alliance_id;
        public int? character_id;
        public int? corporation_id;
        public int damage_done;
        public int? faction_id;
        public bool final_blow;
        public float security_status;
        public int? ship_type_id;
        public int? weapon_type_id;


    }

    public class Victim
    {
        public int? alliance_id;
        public int? character_id;
        public int? corporation_id;
        public int damage_taken;
        public int? faction_id;
        public List<Item> items;
        public Position position;
        public int ship_type_id;

    }

    public class Item
    {
        public int flag;
        public int item_type_id;
        public List<Item> items;
        public int? quantity_destroyed  ;
        public int? quantity_dropped;
        public int singleton;
    }

    public class Position
    {
        public double x;
        public double y;
        public double z;
    }
    public class KillMail
    {
        public List<Attacker> attackers;
        public int killmail_id;
        public DateTimeOffset killmail_time;
        public int? moon_id;
        public int solar_system_id;
        public Victim victim;
        public int? war_id;
    }
}
