﻿using CreditImmo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnitaireCreditImmo
{
    public class TestCSV
    {
        [Theory]
        [InlineData(300, 100000, 10)]
        public void CSVMakeTest(int duration, double amount, double nominalRate)
        {
            CustomerInput customerInput = new CustomerInput(duration, amount, nominalRate);
            string result = CSVMake(customerInput);
            Assert.Equal("Nb; Mensualité; Capital Rembourse; Capital Restant\r\n1;908,7;100000;0\r\n2;908,7;99091,3;908,7\r\n3;908,7;98182,6;1817,4\r\n4;908,7;97273,90000000001;2726,1000000000004\r\n5;908,7;96365,20000000001;3634,8\r\n6;908,7;95456,50000000001;4543,5\r\n7;908,7;94547,80000000002;5452,2\r\n8;908,7;93639,10000000002;6360,9\r\n9;908,7;92730,40000000002;7269,599999999999\r\n10;908,7;91821,70000000003;8178,299999999999\r\n11;908,7;90913,00000000003;9087\r\n12;908,7;90004,30000000003;9995,7\r\n13;908,7;89095,60000000003;10904,400000000001\r\n14;908,7;88186,90000000004;11813,100000000002\r\n15;908,7;87278,20000000004;12721,800000000003\r\n16;908,7;86369,50000000004;13630,500000000004\r\n17;908,7;85460,80000000005;14539,200000000004\r\n18;908,7;84552,10000000005;15447,900000000005\r\n19;908,7;83643,40000000005;16356,600000000006\r\n20;908,7;82734,70000000006;17265,300000000007\r\n21;908,7;81826,00000000006;18174,000000000007\r\n22;908,7;80917,30000000006;19082,700000000008\r\n23;908,7;80008,60000000006;19991,40000000001\r\n24;908,7;79099,90000000007;20900,10000000001\r\n25;908,7;78191,20000000007;21808,80000000001\r\n26;908,7;77282,50000000007;22717,50000000001\r\n27;908,7;76373,80000000008;23626,20000000001\r\n28;908,7;75465,10000000008;24534,900000000012\r\n29;908,7;74556,40000000008;25443,600000000013\r\n30;908,7;73647,70000000008;26352,300000000014\r\n31;908,7;72739,00000000009;27261,000000000015\r\n32;908,7;71830,30000000009;28169,700000000015\r\n33;908,7;70921,6000000001;29078,400000000016\r\n34;908,7;70012,9000000001;29987,100000000017\r\n35;908,7;69104,2000000001;30895,800000000017\r\n36;908,7;68195,5000000001;31804,50000000002\r\n37;908,7;67286,8000000001;32713,20000000002\r\n38;908,7;66378,10000000011;33621,900000000016\r\n39;908,7;65469,40000000011;34530,60000000001\r\n40;908,7;64560,70000000011;35439,30000000001\r\n41;908,7;63652,00000000012;36348,00000000001\r\n42;908,7;62743,30000000012;37256,700000000004\r\n43;908,7;61834,60000000012;38165,4\r\n44;908,7;60925,900000000125;39074,1\r\n45;908,7;60017,20000000013;39982,799999999996\r\n46;908,7;59108,50000000013;40891,49999999999\r\n47;908,7;58199,800000000134;41800,19999999999\r\n48;908,7;57291,10000000014;42708,89999999999\r\n49;908,7;56382,40000000014;43617,599999999984\r\n50;908,7;55473,70000000014;44526,29999999998\r\n51;908,7;54565,000000000146;45434,99999999998\r\n52;908,7;53656,30000000015;46343,699999999975\r\n53;908,7;52747,60000000015;47252,39999999997\r\n54;908,7;51838,900000000154;48161,09999999997\r\n55;908,7;50930,20000000016;49069,79999999997\r\n56;908,7;50021,50000000016;49978,49999999996\r\n57;908,7;49112,80000000016;50887,19999999996\r\n58;908,7;48204,100000000166;51795,89999999996\r\n59;908,7;47295,40000000017;52704,599999999955\r\n60;908,7;46386,70000000017;53613,29999999995\r\n61;908,7;45478,000000000175;54521,99999999995\r\n62;908,7;44569,30000000018;55430,699999999946\r\n63;908,7;43660,60000000018;56339,39999999994\r\n64;908,7;42751,90000000018;57248,09999999994\r\n65;908,7;41843,200000000186;58156,79999999994\r\n66;908,7;40934,50000000019;59065,499999999935\r\n67;908,7;40025,80000000019;59974,19999999993\r\n68;908,7;39117,100000000195;60882,89999999993\r\n69;908,7;38208,4000000002;61791,599999999926\r\n70;908,7;37299,7000000002;62700,29999999992\r\n71;908,7;36391,000000000204;63608,99999999992\r\n72;908,7;35482,30000000021;64517,69999999992\r\n73;908,7;34573,60000000021;65426,399999999914\r\n74;908,7;33664,90000000021;66335,09999999992\r\n75;908,7;32756,20000000021;67243,79999999992\r\n76;908,7;31847,50000000021;68152,49999999991\r\n77;908,7;30938,80000000021;69061,19999999991\r\n78;908,7;30030,10000000021;69969,8999999999\r\n79;908,7;29121,40000000021;70878,5999999999\r\n80;908,7;28212,700000000208;71787,2999999999\r\n81;908,7;27304,000000000207;72695,9999999999\r\n82;908,7;26395,300000000207;73604,6999999999\r\n83;908,7;25486,600000000206;74513,39999999989\r\n84;908,7;24577,900000000205;75422,09999999989\r\n85;908,7;23669,200000000204;76330,79999999989\r\n86;908,7;22760,500000000204;77239,49999999988\r\n87;908,7;21851,800000000203;78148,19999999988\r\n88;908,7;20943,100000000202;79056,89999999988\r\n89;908,7;20034,4000000002;79965,59999999987\r\n90;908,7;19125,7000000002;80874,29999999987\r\n91;908,7;18217,0000000002;81782,99999999987\r\n92;908,7;17308,3000000002;82691,69999999987\r\n93;908,7;16399,6000000002;83600,39999999986\r\n94;908,7;15490,900000000198;84509,09999999986\r\n95;908,7;14582,200000000197;85417,79999999986\r\n96;908,7;13673,500000000196;86326,49999999985\r\n97;908,7;12764,800000000196;87235,19999999985\r\n98;908,7;11856,100000000195;88143,89999999985\r\n99;908,7;10947,400000000194;89052,59999999985\r\n100;908,7;10038,700000000194;89961,29999999984\r\n101;908,7;9130,000000000193;90869,99999999984\r\n102;908,7;8221,300000000192;91778,69999999984\r\n103;908,7;7312,600000000192;92687,39999999983\r\n104;908,7;6403,900000000192;93596,09999999983\r\n105;908,7;5495,200000000193;94504,79999999983\r\n106;908,7;4586,500000000193;95413,49999999983\r\n107;908,7;3677,800000000193;96322,19999999982\r\n108;908,7;2769,100000000193;97230,89999999982\r\n109;908,7;1860,4000000001931;98139,59999999982\r\n110;908,7;951,7000000001931;99048,29999999981\r\n111;908,7;43,00000000019304;99956,99999999981\r\n112;908,7;-865,699999999807;100865,69999999981\r\n113;908,7;-1774,399999999807;101774,3999999998\r\n114;908,7;-2683,099999999807;102683,0999999998\r\n115;908,7;-3591,7999999998074;103591,7999999998\r\n116;908,7;-4500,499999999807;104500,4999999998\r\n117;908,7;-5409,199999999807;105409,1999999998\r\n118;908,7;-6317,899999999807;106317,89999999979\r\n119;908,7;-7226,599999999807;107226,59999999979\r\n120;908,7;-8135,2999999998065;108135,29999999978\r\n121;908,7;-9043,999999999807;109043,99999999978\r\n122;908,7;-9952,699999999808;109952,69999999978\r\n123;908,7;-10861,399999999809;110861,39999999978\r\n124;908,7;-11770,09999999981;111770,09999999977\r\n125;908,7;-12678,79999999981;112678,79999999977\r\n126;908,7;-13587,49999999981;113587,49999999977\r\n127;908,7;-14496,199999999812;114496,19999999976\r\n128;908,7;-15404,899999999812;115404,89999999976\r\n129;908,7;-16313,599999999813;116313,59999999976\r\n130;908,7;-17222,299999999814;117222,29999999976\r\n131;908,7;-18130,999999999814;118130,99999999975\r\n132;908,7;-19039,699999999815;119039,69999999975\r\n133;908,7;-19948,399999999816;119948,39999999975\r\n134;908,7;-20857,099999999817;120857,09999999974\r\n135;908,7;-21765,799999999817;121765,79999999974\r\n136;908,7;-22674,499999999818;122674,49999999974\r\n137;908,7;-23583,19999999982;123583,19999999974\r\n138;908,7;-24491,89999999982;124491,89999999973\r\n139;908,7;-25400,59999999982;125400,59999999973\r\n140;908,7;-26309,29999999982;126309,29999999973\r\n141;908,7;-27217,99999999982;127217,99999999972\r\n142;908,7;-28126,699999999822;128126,69999999972\r\n143;908,7;-29035,399999999823;129035,39999999972\r\n144;908,7;-29944,099999999824;129944,09999999971\r\n145;908,7;-30852,799999999825;130852,79999999971\r\n146;908,7;-31761,499999999825;131761,4999999997\r\n147;908,7;-32670,199999999826;132670,19999999972\r\n148;908,7;-33578,89999999983;133578,89999999973\r\n149;908,7;-34487,599999999824;134487,59999999974\r\n150;908,7;-35396,29999999982;135396,29999999976\r\n151;908,7;-36304,99999999982;136304,99999999977\r\n152;908,7;-37213,699999999815;137213,69999999978\r\n153;908,7;-38122,39999999981;138122,3999999998\r\n154;908,7;-39031,09999999981;139031,0999999998\r\n155;908,7;-39939,79999999981;139939,7999999998\r\n156;908,7;-40848,4999999998;140848,49999999983\r\n157;908,7;-41757,1999999998;141757,19999999984\r\n158;908,7;-42665,8999999998;142665,89999999985\r\n159;908,7;-43574,599999999795;143574,59999999986\r\n160;908,7;-44483,29999999979;144483,29999999987\r\n161;908,7;-45391,99999999979;145391,99999999988\r\n162;908,7;-46300,699999999786;146300,6999999999\r\n163;908,7;-47209,39999999978;147209,3999999999\r\n164;908,7;-48118,09999999978;148118,09999999992\r\n165;908,7;-49026,79999999978;149026,79999999993\r\n166;908,7;-49935,499999999774;149935,49999999994\r\n167;908,7;-50844,19999999977;150844,19999999995\r\n168;908,7;-51752,89999999977;151752,89999999997\r\n169;908,7;-52661,599999999766;152661,59999999998\r\n170;908,7;-53570,29999999976;153570,3\r\n171;908,7;-54478,99999999976;154479\r\n172;908,7;-55387,69999999976;155387,7\r\n173;908,7;-56296,399999999754;156296,40000000002\r\n174;908,7;-57205,09999999975;157205,10000000003\r\n175;908,7;-58113,79999999975;158113,80000000005\r\n176;908,7;-59022,499999999745;159022,50000000006\r\n177;908,7;-59931,19999999974;159931,20000000007\r\n178;908,7;-60839,89999999974;160839,90000000008\r\n179;908,7;-61748,59999999974;161748,6000000001\r\n180;908,7;-62657,299999999734;162657,3000000001\r\n181;908,7;-63565,99999999973;163566,00000000012\r\n182;908,7;-64474,69999999973;164474,70000000013\r\n183;908,7;-65383,399999999725;165383,40000000014\r\n184;908,7;-66292,09999999973;166292,10000000015\r\n185;908,7;-67200,79999999973;167200,80000000016\r\n186;908,7;-68109,49999999972;168109,50000000017\r\n187;908,7;-69018,19999999972;169018,2000000002\r\n188;908,7;-69926,89999999972;169926,9000000002\r\n189;908,7;-70835,59999999971;170835,6000000002\r\n190;908,7;-71744,29999999971;171744,30000000022\r\n191;908,7;-72652,99999999971;172653,00000000023\r\n192;908,7;-73561,6999999997;173561,70000000024\r\n193;908,7;-74470,3999999997;174470,40000000026\r\n194;908,7;-75379,0999999997;175379,10000000027\r\n195;908,7;-76287,7999999997;176287,80000000028\r\n196;908,7;-77196,4999999997;177196,5000000003\r\n197;908,7;-78105,19999999969;178105,2000000003\r\n198;908,7;-79013,89999999969;179013,9000000003\r\n199;908,7;-79922,59999999969;179922,60000000033\r\n200;908,7;-80831,29999999968;180831,30000000034\r\n201;908,7;-81739,99999999968;181740,00000000035\r\n202;908,7;-82648,69999999968;182648,70000000036\r\n203;908,7;-83557,39999999967;183557,40000000037\r\n204;908,7;-84466,09999999967;184466,10000000038\r\n205;908,7;-85374,79999999967;185374,8000000004\r\n206;908,7;-86283,49999999967;186283,5000000004\r\n207;908,7;-87192,19999999966;187192,20000000042\r\n208;908,7;-88100,89999999966;188100,90000000043\r\n209;908,7;-89009,59999999966;189009,60000000044\r\n210;908,7;-89918,29999999965;189918,30000000045\r\n211;908,7;-90826,99999999965;190827,00000000047\r\n212;908,7;-91735,69999999965;191735,70000000048\r\n213;908,7;-92644,39999999964;192644,4000000005\r\n214;908,7;-93553,09999999964;193553,1000000005\r\n215;908,7;-94461,79999999964;194461,8000000005\r\n216;908,7;-95370,49999999964;195370,50000000052\r\n217;908,7;-96279,19999999963;196279,20000000054\r\n218;908,7;-97187,89999999963;197187,90000000055\r\n219;908,7;-98096,59999999963;198096,60000000056\r\n220;908,7;-99005,29999999962;199005,30000000057\r\n221;908,7;-99913,99999999962;199914,00000000058\r\n222;908,7;-100822,69999999962;200822,7000000006\r\n223;908,7;-101731,39999999962;201731,4000000006\r\n224;908,7;-102640,09999999961;202640,10000000062\r\n225;908,7;-103548,79999999961;203548,80000000063\r\n226;908,7;-104457,4999999996;204457,50000000064\r\n227;908,7;-105366,1999999996;205366,20000000065\r\n228;908,7;-106274,8999999996;206274,90000000066\r\n229;908,7;-107183,5999999996;207183,60000000068\r\n230;908,7;-108092,2999999996;208092,3000000007\r\n231;908,7;-109000,99999999959;209001,0000000007\r\n232;908,7;-109909,69999999959;209909,7000000007\r\n233;908,7;-110818,39999999959;210818,40000000072\r\n234;908,7;-111727,09999999958;211727,10000000073\r\n235;908,7;-112635,79999999958;212635,80000000075\r\n236;908,7;-113544,49999999958;213544,50000000076\r\n237;908,7;-114453,19999999958;214453,20000000077\r\n238;908,7;-115361,89999999957;215361,90000000078\r\n239;908,7;-116270,59999999957;216270,6000000008\r\n240;908,7;-117179,29999999957;217179,3000000008\r\n241;908,7;-118087,99999999956;218088,00000000081\r\n242;908,7;-118996,69999999956;218996,70000000083\r\n243;908,7;-119905,39999999956;219905,40000000084\r\n244;908,7;-120814,09999999955;220814,10000000085\r\n245;908,7;-121722,79999999955;221722,80000000086\r\n246;908,7;-122631,49999999955;222631,50000000087\r\n247;908,7;-123540,19999999955;223540,20000000088\r\n248;908,7;-124448,89999999954;224448,9000000009\r\n249;908,7;-125357,59999999954;225357,6000000009\r\n250;908,7;-126266,29999999954;226266,30000000092\r\n251;908,7;-127174,99999999953;227175,00000000093\r\n252;908,7;-128083,69999999953;228083,70000000094\r\n253;908,7;-128992,39999999953;228992,40000000095\r\n254;908,7;-129901,09999999953;229901,10000000097\r\n255;908,7;-130809,79999999952;230809,80000000098\r\n256;908,7;-131718,49999999953;231718,500000001\r\n257;908,7;-132627,19999999955;232627,200000001\r\n258;908,7;-133535,89999999956;233535,900000001\r\n259;908,7;-134444,59999999957;234444,60000000102\r\n260;908,7;-135353,29999999958;235353,30000000104\r\n261;908,7;-136261,9999999996;236262,00000000105\r\n262;908,7;-137170,6999999996;237170,70000000106\r\n263;908,7;-138079,39999999962;238079,40000000107\r\n264;908,7;-138988,09999999963;238988,10000000108\r\n265;908,7;-139896,79999999964;239896,8000000011\r\n266;908,7;-140805,49999999965;240805,5000000011\r\n267;908,7;-141714,19999999966;241714,20000000112\r\n268;908,7;-142622,89999999967;242622,90000000113\r\n269;908,7;-143531,5999999997;243531,60000000114\r\n270;908,7;-144440,2999999997;244440,30000000115\r\n271;908,7;-145348,9999999997;245349,00000000116\r\n272;908,7;-146257,69999999972;246257,70000000118\r\n273;908,7;-147166,39999999973;247166,4000000012\r\n274;908,7;-148075,09999999974;248075,1000000012\r\n275;908,7;-148983,79999999976;248983,8000000012\r\n276;908,7;-149892,49999999977;249892,50000000122\r\n277;908,7;-150801,19999999978;250801,20000000123\r\n278;908,7;-151709,8999999998;251709,90000000125\r\n279;908,7;-152618,5999999998;252618,60000000126\r\n280;908,7;-153527,2999999998;253527,30000000127\r\n281;908,7;-154435,99999999983;254436,00000000128\r\n282;908,7;-155344,69999999984;255344,7000000013\r\n283;908,7;-156253,39999999985;256253,4000000013\r\n284;908,7;-157162,09999999986;257162,10000000132\r\n285;908,7;-158070,79999999987;258070,80000000133\r\n286;908,7;-158979,49999999988;258979,50000000134\r\n287;908,7;-159888,1999999999;259888,20000000135\r\n288;908,7;-160796,8999999999;260796,90000000136\r\n289;908,7;-161705,59999999992;261705,60000000137\r\n290;908,7;-162614,29999999993;262614,3000000014\r\n291;908,7;-163522,99999999994;263523,0000000014\r\n292;908,7;-164431,69999999995;264431,7000000014\r\n293;908,7;-165340,39999999997;265340,4000000014\r\n294;908,7;-166249,09999999998;266249,10000000143\r\n295;908,7;-167157,8;267157,80000000144\r\n296;908,7;-168066,5;268066,50000000146\r\n297;908,7;-168975,2;268975,20000000147\r\n298;908,7;-169883,90000000002;269883,9000000015\r\n299;908,7;-170792,60000000003;270792,6000000015\r\n300;908,7;-171701,30000000005;271701,3000000015\r\n", result);
        }

        public string CSVMake(CustomerInput customerInput)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Calculation calculation = new Calculation();
            double monthlypayment = calculation.CalculateMonthlyPayment(customerInput);
            double debt = customerInput.GetAmount();
            double debtrefund = 0;
            stringBuilder.AppendLine($"Nb; Mensualité; Capital Rembourse; Capital Restant");
            for (int i = 0; i < customerInput.GetDuration(); i++)
            {
                stringBuilder.AppendLine($"{i + 1};{monthlypayment};{debt};{debtrefund}");
                debt -= monthlypayment;
                debtrefund += monthlypayment;
            }

            return stringBuilder.ToString();
        }
    }
}
