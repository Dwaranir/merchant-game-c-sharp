﻿using System.Configuration;
using System.Collections.Specialized;
using MerchantGame;
using MerchantGame.Entities;
using MerchantGame.Models;


Migrations migrations = new Migrations();

migrations.Migrate();
Merchant Player = new();
List<Good> Goods = GoodsModel.GetAllGoods();
Shop shop = new(Goods);
shop.GenerateRequiredGoods();


