﻿dotnet ef dbcontext scaffold "Host=localhost;Database=ceve_tqkb;Username=postgres;Password=" Npgsql.EntityFrameworkCore.PostgreSQL -o Model  -v -d   --use-database-names  -t killboard_alliances -t killboard_character -t killboard_corporation -t killboard_itemprice -t killboard_kill -t killboard_killattacker -t killboard_killitem -t killboard_killmailraw -t killboard_waiting_api -t achievement_achievement -t achievement_char_achievement -t achievement_km_achivement -t achievement_type  -f -c Db