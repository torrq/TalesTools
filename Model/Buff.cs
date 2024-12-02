﻿using System;
using System.Collections.Generic;
using System.Drawing;
using _4RTools.Utils;

namespace _4RTools.Model
{
    internal class Buff
    {
        public String name { get; set; }
        public EffectStatusIDs effectStatusID { get; set; }
        public Bitmap icon { get; set; }

        public Buff(string name, EffectStatusIDs effectStatus, Bitmap icon)
        {
            this.name = name;
            this.effectStatusID = effectStatus;
            this.icon = icon;
        }

        //--------------------- SKILLS ------------------------------

        //Archer Skills
        public static List<Buff> GetArcherSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Concentração", EffectStatusIDs.CONCENTRATION, Resources._4RTools.Icons.ac_concentration),
                new Buff("Caminho do Vento", EffectStatusIDs.WINDWALK, Resources._4RTools.Icons.sn_windwalk),
                new Buff("Visão Real", EffectStatusIDs.TRUESIGHT, Resources._4RTools.Icons.sn_sight),
                new Buff("Ilimitar", EffectStatusIDs.UNLIMIT, Resources._4RTools.Icons.Ilimitar),
                new Buff("Poema de Bragi", EffectStatusIDs.POEMBRAGI, Resources._4RTools.Icons.poem_of_bragi),
                new Buff("Sinfonia dos Ventos", EffectStatusIDs.RUSH_WINDMILL, Resources._4RTools.Icons.windmill_rush),
                new Buff("Serenata ao Luar", EffectStatusIDs.MOONLIT_SERENADE, Resources._4RTools.Icons.moonlight_serenade),
                new Buff("Canção de Frigga", EffectStatusIDs.FRIGG_SONG, Resources._4RTools.Icons.friggs_song),
                new Buff("Disparo Selvagem", EffectStatusIDs.FEARBREEZE, Resources._4RTools.Icons.fear_breeze),
                new Buff("Dança com Lobos", EffectStatusIDs.DANCE_WITH_WUG, Resources._4RTools.Icons.dance_with_wug),
            };

            return skills;
        }

        //Swordsman Skills
        public static List<Buff> GetSwordmanSkill()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Vigor", EffectStatusIDs.ENDURE, Resources._4RTools.Icons.sm_endure),
                new Buff("Instinto de Sobrevivência", EffectStatusIDs.AUTOBERSERK, Resources._4RTools.Icons.sm_autoberserk),
                new Buff("Bloqueio", EffectStatusIDs.AUTOGUARD, Resources._4RTools.Icons.cr_autoguard),
                new Buff("Escudo Refletor", EffectStatusIDs.REFLECTSHIELD, Resources._4RTools.Icons.cr_reflectshield),
                new Buff("Rapidez com Lança", EffectStatusIDs.SPEARQUICKEN, Resources._4RTools.Icons.cr_spearquicken),
                new Buff("Aura Sagrada", EffectStatusIDs.DEFENDER, Resources._4RTools.Icons.cr_defender),
                new Buff("Dedicação", EffectStatusIDs.LKCONCENTRATION, Resources._4RTools.Icons.lk_concentration),
                new Buff("Frenesi", EffectStatusIDs.BERSERK, Resources._4RTools.Icons.lk_berserk),
                new Buff("Rapidez com Duas Mãos", EffectStatusIDs.TWOHANDQUICKEN, Resources._4RTools.Icons.mer_quicken),
                new Buff("Aparar Golpe", EffectStatusIDs.PARRYING, Resources._4RTools.Icons.ms_parrying),
                new Buff("Lâmina de Aura", EffectStatusIDs.AURABLADE, Resources._4RTools.Icons.lk_aurablade),
                new Buff("Encantar Lâmina", EffectStatusIDs.ENCHANT_BLADE, Resources._4RTools.Icons.enchant_blade),
                new Buff("Submissão", EffectStatusIDs.CR_SHRINK, Resources._4RTools.Icons.cr_shrink),
                new Buff("Consagração", EffectStatusIDs.INSPIRATION, Resources._4RTools.Icons.lg_inspiration),
                new Buff("Prestige", EffectStatusIDs.PRESTIGE, Resources._4RTools.Icons.lg_prestige),
                new Buff("Shield Spell", EffectStatusIDs.SHIELDSPELL, Resources._4RTools.Icons.lg_shieldspell),
                new Buff("Proteção da Vanguarda", EffectStatusIDs.FORCEOFVANGUARD, Resources._4RTools.Icons.vanguard_force),
                new Buff("Impacto Explosivo", EffectStatusIDs.MAGNUM, Resources._4RTools.Icons.magnum),
                new Buff("Rapidez com Uma Mão", EffectStatusIDs.ONEHANDQUICKEN, Resources._4RTools.Icons.onehand),
                new Buff("Provocar", EffectStatusIDs.PROVOKE, Resources._4RTools.Icons.provoke),
            };

            return skills;
        }

        //Mage Skills
        public static List<Buff> GetMageSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Proteção Arcana", EffectStatusIDs.ENERGYCOAT, Resources._4RTools.Icons.mg_energycoat),
                new Buff("Explosão Protetora", EffectStatusIDs.SIGHTBLASTER, Resources._4RTools.Icons.wz_sightblaster),
                new Buff("Desejo Arcano", EffectStatusIDs.AUTOSPELL, Resources._4RTools.Icons.sa_autospell),
                new Buff("Lanças Duplas", EffectStatusIDs.DOUBLECASTING, Resources._4RTools.Icons.pf_doublecasting),
                new Buff("Presciência", EffectStatusIDs.MEMORIZE, Resources._4RTools.Icons.pf_memorize),
                new Buff("Telecinesia", EffectStatusIDs.TELEKINESIS_INTENSE, Resources._4RTools.Icons.telecinese),
                new Buff("Amplificação Mística", EffectStatusIDs.MYST_AMPLIFY, Resources._4RTools.Icons.amplify),
                new Buff("Maestria Arcana", EffectStatusIDs.RECOGNIZEDSPELL, Resources._4RTools.Icons.recognized_spell),
                new Buff("Enlouquecedor", EffectStatusIDs.MINDBREAKER, Resources._4RTools.Icons.mindbreaker),
            };

            return skills;
        }

        //Merchant Skills
        public static List<Buff> GetMerchantSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Grito de Guerra", EffectStatusIDs.CRAZY_UPROAR, Resources._4RTools.Icons.mc_loud),
                new Buff("Força Violenta", EffectStatusIDs.OVERTHRUST, Resources._4RTools.Icons.bs_overthrust),
                new Buff("Adrenalina Pura", EffectStatusIDs.ADRENALINE, Resources._4RTools.Icons.bs_adrenaline),
                new Buff("Adrenalina Concentrada", EffectStatusIDs.ADRENALINE2, Resources._4RTools.Icons.bs_adrenaline2),
                new Buff("Força Violentíssima", EffectStatusIDs.OVERTHRUSTMAX, Resources._4RTools.Icons.ws_overthrustmax),
                new Buff("Manejo Perfeito", EffectStatusIDs.WEAPONPERFECT, Resources._4RTools.Icons.bs_weaponperfect),
                new Buff("Amplificar Poder", EffectStatusIDs.MAXIMIZE, Resources._4RTools.Icons.bs_maximize),
                new Buff("Impulso no Carrinho", EffectStatusIDs.CARTBOOST, Resources._4RTools.Icons.ws_cartboost),
                new Buff("Golpe Estilhaçante", EffectStatusIDs.MELTDOWN, Resources._4RTools.Icons.ws_meltdown),
                new Buff("Aceleração", EffectStatusIDs.ACCELERATION, Resources._4RTools.Icons.mec_acceleration),
                new Buff("Propulsão do Carrinho", EffectStatusIDs.GN_CARTBOOST, Resources._4RTools.Icons.cart_boost),
                new Buff("Research Report", EffectStatusIDs.RESEARCHREPORT, Resources._4RTools.Icons.researchreport),
                new Buff("Bater em Retirada", EffectStatusIDs.HOM_AVOID, Resources._4RTools.Icons.hom_avoid)
            };

            return skills;
        }

        //Thief Skills
        public static List<Buff> GetThiefSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Refletir Veneno", EffectStatusIDs.POISONREACT, Resources._4RTools.Icons.as_poisonreact),
                new Buff("Instinto de Defesa", EffectStatusIDs.SWORDREJECT, Resources._4RTools.Icons.st_rejectsword),
                new Buff("Preservar", EffectStatusIDs.PRESERVE, Resources._4RTools.Icons.st_preserve),
                new Buff("Encantar com Veneno Mortal", EffectStatusIDs.EDP, Resources._4RTools.Icons.asc_edp),
                new Buff("Reflexo de Combate", EffectStatusIDs.WEAPONBLOCKING, Resources._4RTools.Icons.weapon_blocking),
                new Buff("Esconderijo", EffectStatusIDs.HIDING, Resources._4RTools.Icons.hiding),
                new Buff("Furtividade", EffectStatusIDs.CLOAKING, Resources._4RTools.Icons.cloaking),
                new Buff("Desejo das Sombras", EffectStatusIDs.AUTOSHADOWSPELL, Resources._4RTools.Icons.autoshadowspell)

            };

            return skills;
        }

        //Acolyte Skills
        public static List<Buff> GetAcolyteSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Glória", EffectStatusIDs.GLORIA, Resources._4RTools.Icons.pr_gloria),
                new Buff("Magnificat", EffectStatusIDs.MAGNIFICAT, Resources._4RTools.Icons.pr_magnificat),
                new Buff("Angelus", EffectStatusIDs.ANGELUS, Resources._4RTools.Icons.al_angelus),
                new Buff("Dragão Ascendente", EffectStatusIDs.RAISINGDRAGON, Resources._4RTools.Icons.rising_dragon),
                new Buff("Firm Faith", EffectStatusIDs.FIRM_FAITH, Resources._4RTools.Icons.firm_faith),
                new Buff("Powerful Faith", EffectStatusIDs.POWERFUL_FAITH, Resources._4RTools.Icons.powerful_faith),
                new Buff("Chakra do Vigor", EffectStatusIDs.GENTLETOUCH_REVITALIZE, Resources._4RTools.Icons.gentle_touch_revitalize),
                new Buff("Chakra da Fúria", EffectStatusIDs.GENTLETOUCH_CHANGE, Resources._4RTools.Icons.gentle_touch_convert),
                new Buff("Fúria Interior", EffectStatusIDs.FURY, Resources._4RTools.Icons.fury),
                new Buff("Impositio Manus", EffectStatusIDs.IMPOSITIO, Resources._4RTools.Icons.impositio_manus),
                new Buff("Lauda Agnus", EffectStatusIDs.LAUDA_AGNUS, Resources._4RTools.Icons.lauda_agnus),
                new Buff("Lauda Ramus", EffectStatusIDs.LAUDA_RAMUS, Resources._4RTools.Icons.lauda_ramus),
                new Buff("Basílica", EffectStatusIDs.BASILICA, Resources._4RTools.Icons.basilica),
            };

            return skills;
        }

        //Ninja Skills
        public static List<Buff> GetNinjaSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Troca de Pele", EffectStatusIDs.PEEL_CHANGE, Resources._4RTools.Icons.nj_utsusemi),
                new Buff("Aura Ninja", EffectStatusIDs.AURA_NINJA, Resources._4RTools.Icons.nj_nen),
                new Buff("Inspiração", EffectStatusIDs.IZAYOI, Resources._4RTools.Icons.izayoi),
                new Buff("Imagem Falsa", EffectStatusIDs.BUNSINJYUTSU, Resources._4RTools.Icons.bunsinjyutsu)
            };

            return skills;
        }

        //Taekwon Skills
        public static List<Buff> GetTaekwonSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Brisa Leve (Terra)", EffectStatusIDs.PROPERTYGROUND, Resources._4RTools.Icons.tk_mild_earth),
                new Buff("Brisa Leve (Fogo)", EffectStatusIDs.PROPERTYFIRE, Resources._4RTools.Icons.tk_mild_fire),
                new Buff("Brisa Leve (Água)", EffectStatusIDs.PROPERTYWATER, Resources._4RTools.Icons.tk_mild_water),
                new Buff("Brisa Leve (Vento)", EffectStatusIDs.PROPERTYWIND, Resources._4RTools.Icons.tk_mild_wind),
                new Buff("Brisa Leve (Fantasma)", EffectStatusIDs.PROPERTYTELEKINESIS, Resources._4RTools.Icons.tk_mild_ghost),
                new Buff("Brisa Leve (Sagrado)", EffectStatusIDs.ASPERSIO, Resources._4RTools.Icons.tk_mild_holy),
                new Buff("Brisa Leve (Sombrio)", EffectStatusIDs.PROPERTYDARK, Resources._4RTools.Icons.tk_mild_shadow),
                new Buff("Cambalhota", EffectStatusIDs.DODGE_ON, Resources._4RTools.Icons.tumbling),
                new Buff("Milagre Solar, Lunar e Estelar", EffectStatusIDs.SPIRIT, Resources._4RTools.Icons.solar_miracle),
                new Buff("Calor Solar, Lunar, Estelar", EffectStatusIDs.WARM, Resources._4RTools.Icons.sun_warm),
                new Buff("Proteção Solar", EffectStatusIDs.SUN_COMFORT, Resources._4RTools.Icons.sun_comfort),
                new Buff("Proteção Lunar", EffectStatusIDs.MOON_COMFORT, Resources._4RTools.Icons.moon_comfort),
                new Buff("Proteção Estelar", EffectStatusIDs.STAR_COMFORT, Resources._4RTools.Icons.star_comfort),
                new Buff("União Solar, Lunar e Estelar", EffectStatusIDs.FUSION, Resources._4RTools.Icons.fusion),
                new Buff("Kaupe", EffectStatusIDs.KAUPE, Resources._4RTools.Icons.kaupe),
                new Buff("Kaite", EffectStatusIDs.KAITE, Resources._4RTools.Icons.kaite),
                new Buff("Kaizel", EffectStatusIDs.KAIZEL, Resources._4RTools.Icons.kaizel),
                new Buff("Kaahi", EffectStatusIDs.KAAHI, Resources._4RTools.Icons.kaahi),
                new Buff("Corrida", EffectStatusIDs.RUN, Resources._4RTools.Icons.run),

            };

            return skills;
        }


        public static List<Buff> GetGunsSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Ataque Gatling", EffectStatusIDs.GATLINGFEVER, Resources._4RTools.Icons.gatling_fever),
                new Buff("Resistência Final", EffectStatusIDs.MADNESSCANCEL, Resources._4RTools.Icons.madnesscancel),
                new Buff("Pânico do Justiceiro", EffectStatusIDs.ADJUSTMENT, Resources._4RTools.Icons.adjustment),
                new Buff("Aumentar Precisão", EffectStatusIDs.ACCURACY, Resources._4RTools.Icons.increase_accuracy),
                new Buff("Reação Ilimitada", EffectStatusIDs.E_CHAIN, Resources._4RTools.Icons.e_chain),
            };

            return skills;
        }


        //--------------------- STUFFS ------------------------------
        //--------------------- Potions ------------------------------
        public static List<Buff> GetPotionsBuffs()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Bala de Guaraná | Poção da Concentração", EffectStatusIDs.CONCENTRATION_POTION, Resources._4RTools.Icons.concentration_guarana),
                new Buff("Poção do Despertar", EffectStatusIDs.AWAKENING_POTION, Resources._4RTools.Icons.awakening_potion),
                new Buff("Poção da Fúria Selvagem", EffectStatusIDs.BERSERK_POTION, Resources._4RTools.Icons.berserk_potion),
                new Buff("Poção de Regeneração", EffectStatusIDs.REGENERATION_POTION, Resources._4RTools.Icons.regeneration),
                new Buff("Poção Grande de HP", EffectStatusIDs.HP_INCREASE_POTION_LARGE, Resources._4RTools.Icons.ghp),
                new Buff("Poção Grande de SP", EffectStatusIDs.SP_INCREASE_POTION_LARGE, Resources._4RTools.Icons.gsp),
                new Buff("Ativador de Erva Vermelha", EffectStatusIDs.RED_HERB_ACTIVATOR, Resources._4RTools.Icons.red_herb_activator),
                new Buff("Ativador de Erva Azul", EffectStatusIDs.BLUE_HERB_ACTIVATOR, Resources._4RTools.Icons.blue_herb_activator),
                new Buff("Poção X Dourada", EffectStatusIDs.REF_T_POTION, Resources._4RTools.Icons.Golden_X),
                new Buff("Poção de Mega Resistência", EffectStatusIDs.TARGET_BLOOD, Resources._4RTools.Icons.mega_resist_potion),
                new Buff("Poção do Furor Físico", EffectStatusIDs.FULL_SWINGK, Resources._4RTools.Icons.swing_k),
                new Buff("Poção do Furor Mágico", EffectStatusIDs.MANA_PLUS, Resources._4RTools.Icons.mana_plus),
                new Buff("Suco de Gato", EffectStatusIDs.SPELLBREAKER, Resources._4RTools.Icons.spellbreaker),
                new Buff("Poção Mental", EffectStatusIDs.MENTAL_POTION, Resources._4RTools.Icons.mental_potion),
                new Buff("Poção Vitata 500", EffectStatusIDs.VITATA_POTION, Resources._4RTools.Icons.vitata_potion),
                new Buff("Elixir Rubro", EffectStatusIDs.RED_BOOSTER, Resources._4RTools.Icons.red_booster_potion),
                new Buff("Poção do Bovino Furioso", EffectStatusIDs.BOVINE, Resources._4RTools.Icons.bovine_potion),
                new Buff("Poção do Dragão Místico", EffectStatusIDs.DRAGON, Resources._4RTools.Icons.dragon_potion),
            };

            return skills;
        }

        public static List<Buff> GetElementalsBuffs()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Conversor Elemental Fogo", EffectStatusIDs.PROPERTYFIRE, Resources._4RTools.Icons.ele_fire_converter),
                new Buff("Conversor Elemental Vento", EffectStatusIDs.PROPERTYWIND, Resources._4RTools.Icons.ele_wind_converter),
                new Buff("Conversor Elemental Terra", EffectStatusIDs.PROPERTYGROUND, Resources._4RTools.Icons.ele_earth_converter),
                new Buff("Conversor Elemental Água", EffectStatusIDs.PROPERTYWATER, Resources._4RTools.Icons.ele_water_converter),
                new Buff("Pergaminho de Aspersio", EffectStatusIDs.ASPERSIO, Resources._4RTools.Icons.ele_holy_converter),
                new Buff("Conversor Elemental Fantasma", EffectStatusIDs.PROPERTYTELEKINESIS, Resources._4RTools.Icons.ele_ghost_converter),
                new Buff("Água Amaldiçoada", EffectStatusIDs.PROPERTYDARK, Resources._4RTools.Icons.cursed_water),
                new Buff("Poção Anti-Fogo", EffectStatusIDs.RESIST_PROPERTY_FIRE, Resources._4RTools.Icons.fireproof),
                new Buff("Poção Anti-Água", EffectStatusIDs.RESIST_PROPERTY_WATER, Resources._4RTools.Icons.coldproof),
                new Buff("Poção Anti-Vento", EffectStatusIDs.RESIST_PROPERTY_WIND, Resources._4RTools.Icons.thunderproof),
                new Buff("Poção Anti-Terra", EffectStatusIDs.RESIST_PROPERTY_GROUND, Resources._4RTools.Icons.earhproof)
            };

            return skills;
        }

        public static List<Buff> GetFoodBuffs()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("STR Food", EffectStatusIDs.FOOD_STR, Resources._4RTools.Icons.strfood),
                new Buff("AGI Food", EffectStatusIDs.FOOD_AGI, Resources._4RTools.Icons.agi_food),
                new Buff("VIT Food", EffectStatusIDs.FOOD_VIT, Resources._4RTools.Icons.vit_food),
                new Buff("INT Food", EffectStatusIDs.FOOD_INT, Resources._4RTools.Icons.int_food),
                new Buff("DEX Food", EffectStatusIDs.FOOD_DEX, Resources._4RTools.Icons.dex_food),
                new Buff("LUK Food", EffectStatusIDs.FOOD_LUK, Resources._4RTools.Icons.luk_food),

                new Buff("3RD STR Food", EffectStatusIDs.STR_3RD_FOOD, Resources._4RTools.Icons.str_3rd_food),
                new Buff("3RD AGI Food", EffectStatusIDs.AGI_3RD_FOOD, Resources._4RTools.Icons.agi_3rd_food),
                new Buff("3RD VIT Food", EffectStatusIDs.VIT_3RD_FOOD, Resources._4RTools.Icons.vit_3rd_food),
                new Buff("3RD INT Food", EffectStatusIDs.INT_3RD_FOOD, Resources._4RTools.Icons.int_3rd_food),
                new Buff("3RD DEX Food", EffectStatusIDs.DEX_3RD_FOOD, Resources._4RTools.Icons.dex_3rd_food),
                new Buff("3RD LUK Food", EffectStatusIDs.LUK_3RD_FOOD, Resources._4RTools.Icons.luk_3rd_food),
                new Buff("Almighty", EffectStatusIDs.RWC_2011_SCROLL, Resources._4RTools.Icons.almighty),
                new Buff("CASH Food", EffectStatusIDs.FOOD_VIT_CASH, Resources._4RTools.Icons.cash_food),
                new Buff("Acarajé", EffectStatusIDs.ACARAJE, Resources._4RTools.Icons.acaraje),
                new Buff("Palitos de Laranja", EffectStatusIDs.STR_Biscuit_Stick, Resources._4RTools.Icons.STR_Biscuit),
                new Buff("Palitos de Baunilha", EffectStatusIDs.AGI_Biscuit_Stick, Resources._4RTools.Icons.AGI_Biscuit),
                new Buff("Palitos de Cassis", EffectStatusIDs.INT_Biscuit_Stick, Resources._4RTools.Icons.INT_Biscuit),
                new Buff("Palitos de Chocolate", EffectStatusIDs.VIT_Biscuit_Stick, Resources._4RTools.Icons.VIT_Biscuit),
                new Buff("Palitos de Limão", EffectStatusIDs.DEX_Biscuit_Stick, Resources._4RTools.Icons.DEX_Biscuit),
                new Buff("Palitos de Morango", EffectStatusIDs.LUK_Biscuit_Stick, Resources._4RTools.Icons.LUK_Biscuit),
                new Buff("Salada de Frutas Tropicais", EffectStatusIDs.HALOHALO, Resources._4RTools.Icons.halohalo),
                new Buff("Cálice da Ilusão", EffectStatusIDs.GLASS_OF_ILLUSION, Resources._4RTools.Icons.Glass_Of_Illusion),
            };


            return skills;
        }

        public static List<Buff> GetBoxesBuffs()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Caixa da Sonolência", EffectStatusIDs.DROWSINESS_BOX, Resources._4RTools.Icons.drowsiness),
                new Buff("Caixa do Ressentimento", EffectStatusIDs.RESENTMENT_BOX, Resources._4RTools.Icons.resentment),
                new Buff("Caixa da Luz do Sol", EffectStatusIDs.SUNLIGHT_BOX, Resources._4RTools.Icons.sunbox),
                new Buff("Caixa da Escuridão", EffectStatusIDs.CONCENTRATION, Resources._4RTools.Icons.gloom),
                new Buff("Caixa do Trovão", EffectStatusIDs.BOX_OF_THUNDER, Resources._4RTools.Icons.speed),
                new Buff("Poção de Guyak | Poção do Vento", EffectStatusIDs.SPEED_POT, Resources._4RTools.Icons.speedpotion),
                new Buff("Analgésico", EffectStatusIDs.ENDURE, Resources._4RTools.Icons.anodyne),
                new Buff("Aloe Vera", EffectStatusIDs.PROVOKE, Resources._4RTools.Icons.aloevera),
                new Buff("Abrasivo", EffectStatusIDs.CRITICALPERCENT, Resources._4RTools.Icons.abrasive),
                new Buff("Pílula de Combate", EffectStatusIDs.COMBAT_PILL, Resources._4RTools.Icons.combat_pill),
                new Buff("Suco Celular Enriquecido", EffectStatusIDs.ENRICH_CELERMINE_JUICE, Resources._4RTools.Icons.celermine),
                new Buff("Garrafa de Veneno", EffectStatusIDs.ASPDPOTIONINFINITY, Resources._4RTools.Icons.poison)
            };

            return skills;
        }

        public static List<Buff> GetScrollBuffs()
        {
            List<Buff> skills = new List<Buff>
            {

                new Buff("Pergaminho do Éden", EffectStatusIDs.EDEN, Resources._4RTools.Icons.eden_scroll),
                new Buff("Increase Agility Scroll", EffectStatusIDs.INC_AGI, Resources._4RTools.Icons.al_incagi1),
                new Buff("Bless Scroll", EffectStatusIDs.BLESSING, Resources._4RTools.Icons.al_blessing1),
                new Buff("Full Chemical Protection (Scroll)", EffectStatusIDs.PROTECTARMOR, Resources._4RTools.Icons.cr_fullprotection),
                new Buff("Incenso Queimado",  EffectStatusIDs.SPIRIT, Resources._4RTools.Icons.burnt_incense),
                new Buff("Link Scroll", EffectStatusIDs.SOULLINK, Resources._4RTools.Icons.sl_soullinker),
                new Buff("Monster Transform",  EffectStatusIDs.MONSTER_TRANSFORM, Resources._4RTools.Icons.mob_transform),
                new Buff("Assumptio",  EffectStatusIDs.ASSUMPTIO, Resources._4RTools.Icons.assumptio),
                new Buff("Pergaminho de Esquiva",  EffectStatusIDs.FLEE_SCROLL, Resources._4RTools.Icons.flee_scroll),
                new Buff("Pergaminho de Precisão",  EffectStatusIDs.ACCURACY_SCROLL, Resources._4RTools.Icons.accuracy_Scroll),
                
            };

            return skills;
        }

        public static List<Buff> GetETCBuffs()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("LUX AMINA Rune", EffectStatusIDs.LUX_AMINA, Resources._4RTools.Icons.LUX_AMINA),
                new Buff("Cat Can", EffectStatusIDs.OVERLAPEXPUP, Resources._4RTools.Icons.cat_can),
                new Buff("Goma de Mascar", EffectStatusIDs.CASH_RECEIVEITEM, Resources._4RTools.Icons.he_bubble_gum),
                new Buff("Manual de Combate", EffectStatusIDs.CASH_PLUSEXP, Resources._4RTools.Icons.base_combat),
                new Buff("Manual de Combate de classe", EffectStatusIDs.CASH_PLUSECLASSXP, Resources._4RTools.Icons.class_combat),
                new Buff("Pergaminho de Ghostring", EffectStatusIDs.GHOSTRING, Resources._4RTools.Icons.perg_ghostring),
                new Buff("Pergaminho de Angeling", EffectStatusIDs.ANGELING, Resources._4RTools.Icons.perg_angeling),
                new Buff("Pergaminho de Tao Gunka", EffectStatusIDs.TAO_GUNKA, Resources._4RTools.Icons.perg_taogunka),
                new Buff("Pergaminho de Sehnor dos Orcs", EffectStatusIDs.SR_ORCS, Resources._4RTools.Icons.perg_senhororc),
                new Buff("Pergaminho de Orc Herói", EffectStatusIDs.ORC_HEROI, Resources._4RTools.Icons.perg_orcheroi),
                new Buff("Pergaminho de Abelha Rainha", EffectStatusIDs.ABELHA, Resources._4RTools.Icons.perg_abelha),
            };

            return skills;
        }
        //--------------------- DEBUFFS ------------------------------
        public static List<Buff> GetDebuffs()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Ferimento Crítico", EffectStatusIDs.CRITICALWOUND, Resources._4RTools.Icons.critical_wound),
                new Buff("Hipotermia", EffectStatusIDs.FREEZING, Resources._4RTools.Icons.freezing),
                new Buff("Maldição", EffectStatusIDs.CURSE, Resources._4RTools.Icons.curse),
                new Buff("Sangramento", EffectStatusIDs.BLEEDING, Resources._4RTools.Icons.bleeding),
                new Buff("Silêncio", EffectStatusIDs.SILENCE, Resources._4RTools.Icons.silence),
                new Buff("Diminuir Agilidade", EffectStatusIDs.DECREASE_AGI, Resources._4RTools.Icons.decrease_agi),
                new Buff("Caos / Confusão", EffectStatusIDs.CONFUSION, Resources._4RTools.Icons.chaos),
                new Buff("Atordoamento", EffectStatusIDs.STUN, Resources._4RTools.Icons.stun),
                new Buff("Sono Profundo", EffectStatusIDs.DEEP_SLEEP, Resources._4RTools.Icons.deep_sleep),
                new Buff("Envenenamento", EffectStatusIDs.POISON, Resources._4RTools.Icons.poison_status),
                new Buff("Sentar", EffectStatusIDs.SIT, Resources._4RTools.Icons.sit),
                new Buff("Incêndio", EffectStatusIDs.BURNING, Resources._4RTools.Icons.burning),
                new Buff("Grito da Mandrágora", EffectStatusIDs.MANDRAGORA, Resources._4RTools.Icons.mandragora_howling),
                new Buff("Conjuração Lenta", EffectStatusIDs.SLOW_CAST, Resources._4RTools.Icons.slow_cast),

            };

            return skills;
        }


    }
}
