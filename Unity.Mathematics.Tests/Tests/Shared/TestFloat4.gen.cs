// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestFloat4
    {
        [TestCompiler]
        public static void float4_zero()
        {
            TestUtils.AreEqual(float4.zero.x, 0.0f);
            TestUtils.AreEqual(float4.zero.y, 0.0f);
            TestUtils.AreEqual(float4.zero.z, 0.0f);
            TestUtils.AreEqual(float4.zero.w, 0.0f);
        }

        [TestCompiler]
        public static void float4_constructor()
        {
            float4 a = new float4(1, 2, 3, 4);
            TestUtils.AreEqual(a.x, 1);
            TestUtils.AreEqual(a.y, 2);
            TestUtils.AreEqual(a.z, 3);
            TestUtils.AreEqual(a.w, 4);
        }

        [TestCompiler]
        public static void float4_scalar_constructor()
        {
            float4 a = new float4(17.0f);
            TestUtils.AreEqual(a.x, 17.0f);
            TestUtils.AreEqual(a.y, 17.0f);
            TestUtils.AreEqual(a.z, 17.0f);
            TestUtils.AreEqual(a.w, 17.0f);
        }

        [TestCompiler]
        public static void float4_static_constructor()
        {
            float4 a = float4(1, 2, 3, 4);
            TestUtils.AreEqual(a.x, 1);
            TestUtils.AreEqual(a.y, 2);
            TestUtils.AreEqual(a.z, 3);
            TestUtils.AreEqual(a.w, 4);
        }

        [TestCompiler]
        public static void float4_static_scalar_constructor()
        {
            float4 a = float4(17.0f);
            TestUtils.AreEqual(a.x, 17.0f);
            TestUtils.AreEqual(a.y, 17.0f);
            TestUtils.AreEqual(a.z, 17.0f);
            TestUtils.AreEqual(a.w, 17.0f);
        }

        [TestCompiler]
        public static void float4_operator_equal_wide_wide()
        {
            float4 a0 = float4(-135.18924f, -49.0941162f, 169.129822f, 240.8053f);
            float4 b0 = float4(-220.014648f, 66.98004f, 499.2016f, -371.1131f);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float4 a1 = float4(314.7392f, 442.393f, 177.924438f, 335.5334f);
            float4 b1 = float4(208.448669f, 390.8037f, -72.44382f, 362.97644f);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float4 a2 = float4(168.15448f, 350.729553f, 367.178467f, 46.9414673f);
            float4 b2 = float4(194.678345f, 471.644836f, -404.044678f, -144.696747f);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float4 a3 = float4(188.76416f, -97.2113953f, -293.320984f, -234.822937f);
            float4 b3 = float4(-494.446655f, -252.970367f, 234.417114f, 398.724f);
            bool4 r3 = bool4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_equal_wide_scalar()
        {
            float4 a0 = float4(65.6712f, 404.415527f, -269.730164f, 83.6306152f);
            float b0 = (-155.815765f);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float4 a1 = float4(152.9945f, 314.671265f, 386.365173f, 290.04895f);
            float b1 = (-155.868286f);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float4 a2 = float4(-132.6352f, -69.68326f, -191.190765f, 186.845215f);
            float b2 = (-65.66748f);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float4 a3 = float4(-232.895691f, -49.70108f, -300.8819f, 333.396851f);
            float b3 = (-319.144043f);
            bool4 r3 = bool4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_equal_scalar_wide()
        {
            float a0 = (36.38391f);
            float4 b0 = float4(-400.4892f, -71.2868347f, 156.978088f, -225.238739f);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float a1 = (499.141785f);
            float4 b1 = float4(-211.979919f, 428.311951f, -489.501343f, -5.691559f);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float a2 = (-30.8659363f);
            float4 b2 = float4(-362.9831f, 184.503174f, -160.470612f, 316.668823f);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float a3 = (390.369263f);
            float4 b3 = float4(505.1051f, -294.6487f, 443.1991f, 96.5592651f);
            bool4 r3 = bool4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_not_equal_wide_wide()
        {
            float4 a0 = float4(279.994141f, -43.34201f, -465.724731f, 317.466553f);
            float4 b0 = float4(-460.9121f, -476.009033f, 468.1364f, -341.012543f);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float4 a1 = float4(85.7149658f, 360.8905f, 366.081543f, 154.542847f);
            float4 b1 = float4(-62.65805f, -458.801666f, -457.730225f, -59.5232544f);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float4 a2 = float4(332.4262f, 397.11322f, -431.374969f, 489.0108f);
            float4 b2 = float4(3.024231f, 155.812744f, -19.8399048f, -6.01693726f);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float4 a3 = float4(398.4336f, -489.817932f, 171.4049f, -67.82968f);
            float4 b3 = float4(-406.207916f, -102.420715f, -40.362915f, 452.6754f);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_not_equal_wide_scalar()
        {
            float4 a0 = float4(-155.4411f, -19.4266052f, 174.633057f, 507.920715f);
            float b0 = (-393.413544f);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float4 a1 = float4(59.177063f, -58.92328f, -398.176849f, 492.20105f);
            float b1 = (171.151489f);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float4 a2 = float4(-165.241516f, -380.243256f, 501.899048f, -134.345459f);
            float b2 = (270.341f);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float4 a3 = float4(458.400452f, 161.459961f, 261.514221f, -145.6124f);
            float b3 = (46.7709961f);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_not_equal_scalar_wide()
        {
            float a0 = (478.353149f);
            float4 b0 = float4(459.553223f, 436.453247f, -488.714172f, 392.767944f);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float a1 = (-266.736633f);
            float4 b1 = float4(338.557861f, -338.100128f, -152.314545f, -452.820679f);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float a2 = (209.439331f);
            float4 b2 = float4(50.10797f, 372.4344f, -488.0213f, 489.740784f);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float a3 = (270.4001f);
            float4 b3 = float4(-472.846771f, -286.850464f, -384.691864f, 443.423523f);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_less_wide_wide()
        {
            float4 a0 = float4(51.7102661f, -313.85556f, 283.047668f, 235.021912f);
            float4 b0 = float4(-261.835236f, -19.81073f, -149.25882f, 205.99823f);
            bool4 r0 = bool4(false, true, false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            float4 a1 = float4(44.07837f, -207.255676f, 3.38293457f, -144.301331f);
            float4 b1 = float4(-306.024384f, 102.121704f, 231.906311f, 179.49884f);
            bool4 r1 = bool4(false, true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float4 a2 = float4(-69.3696f, -135.667969f, -194.787354f, -33.473877f);
            float4 b2 = float4(473.2249f, 15.8916626f, 270.049927f, 490.914f);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float4 a3 = float4(-19.67508f, 423.237976f, -71.6983f, -501.886f);
            float4 b3 = float4(-185.734131f, 76.4331055f, 97.75232f, 419.300781f);
            bool4 r3 = bool4(false, false, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_less_wide_scalar()
        {
            float4 a0 = float4(-221.869781f, -121.546478f, -97.5239258f, 479.8811f);
            float b0 = (199.0675f);
            bool4 r0 = bool4(true, true, true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            float4 a1 = float4(67.11902f, 282.9666f, 258.2791f, -111.413147f);
            float b1 = (137.3288f);
            bool4 r1 = bool4(true, false, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float4 a2 = float4(-288.081116f, -361.6429f, -68.0881958f, 12.7880249f);
            float b2 = (82.6654053f);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float4 a3 = float4(-66.703064f, 25.7277222f, 101.37085f, -330.442657f);
            float b3 = (-78.76297f);
            bool4 r3 = bool4(false, false, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_less_scalar_wide()
        {
            float a0 = (-250.484924f);
            float4 b0 = float4(-377.196533f, -505.147552f, 375.9267f, 110.17395f);
            bool4 r0 = bool4(false, false, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float a1 = (-118.097565f);
            float4 b1 = float4(-40.4508972f, -299.744324f, 31.4371338f, -458.904541f);
            bool4 r1 = bool4(true, false, true, false);
            TestUtils.AreEqual(a1 < b1, r1);

            float a2 = (13.6846924f);
            float4 b2 = float4(-458.5069f, 248.276489f, 389.231445f, 488.745544f);
            bool4 r2 = bool4(false, true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float a3 = (-221.637878f);
            float4 b3 = float4(-424.2672f, 249.059021f, -22.1361389f, -442.247742f);
            bool4 r3 = bool4(false, true, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_greater_wide_wide()
        {
            float4 a0 = float4(-229.29068f, 505.536621f, -73.80707f, 100.292053f);
            float4 b0 = float4(-445.845032f, -420.035278f, 299.0244f, -13.8809814f);
            bool4 r0 = bool4(true, true, false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float4 a1 = float4(-419.214783f, -159.559753f, -396.770355f, 127.037415f);
            float4 b1 = float4(151.5617f, -163.50943f, -391.096039f, 479.283752f);
            bool4 r1 = bool4(false, true, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            float4 a2 = float4(489.1399f, 51.9188843f, 155.384766f, -135.631653f);
            float4 b2 = float4(-77.6748657f, -46.584198f, -415.377f, 71.46698f);
            bool4 r2 = bool4(true, true, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float4 a3 = float4(-425.978149f, -228.430511f, 383.03833f, 136.533569f);
            float4 b3 = float4(-206.061035f, 360.8363f, 236.968811f, 14.550354f);
            bool4 r3 = bool4(false, false, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_greater_wide_scalar()
        {
            float4 a0 = float4(11.156311f, -411.023224f, 385.885559f, -485.103058f);
            float b0 = (-302.816956f);
            bool4 r0 = bool4(true, false, true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float4 a1 = float4(-491.180023f, 173.575073f, 69.26929f, 501.306824f);
            float b1 = (405.175354f);
            bool4 r1 = bool4(false, false, false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float4 a2 = float4(-367.027771f, -489.090576f, -172.518158f, -18.1496277f);
            float b2 = (-86.12451f);
            bool4 r2 = bool4(false, false, false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            float4 a3 = float4(-236.414948f, -27.2391357f, 471.779358f, 240.164551f);
            float b3 = (-238.8945f);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_greater_scalar_wide()
        {
            float a0 = (453.546082f);
            float4 b0 = float4(-226.2044f, -423.465f, 409.405518f, 453.877075f);
            bool4 r0 = bool4(true, true, true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float a1 = (87.47571f);
            float4 b1 = float4(113.795593f, 176.409241f, -140.440033f, -182.48288f);
            bool4 r1 = bool4(false, false, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float a2 = (-158.2933f);
            float4 b2 = float4(-162.685333f, -193.328674f, 230.181274f, -102.58783f);
            bool4 r2 = bool4(true, true, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float a3 = (392.520569f);
            float4 b3 = float4(-177.478668f, -10.2950134f, -24.04895f, 172.448669f);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_less_equal_wide_wide()
        {
            float4 a0 = float4(240.090515f, 462.213135f, 293.08252f, -427.870667f);
            float4 b0 = float4(-81.20383f, 493.637451f, -411.4721f, 99.16443f);
            bool4 r0 = bool4(false, true, false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float4 a1 = float4(-405.5227f, 204.591919f, 294.6701f, -327.564453f);
            float4 b1 = float4(-295.6677f, -480.462555f, 74.41406f, 260.916138f);
            bool4 r1 = bool4(true, false, false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float4 a2 = float4(-456.12326f, 282.30127f, 421.881165f, -311.71283f);
            float4 b2 = float4(306.173279f, 139.564819f, -505.752472f, -489.6268f);
            bool4 r2 = bool4(true, false, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float4 a3 = float4(84.5675049f, 447.244629f, -154.494354f, -424.364746f);
            float4 b3 = float4(-280.0326f, 303.1599f, 511.1902f, -104.659729f);
            bool4 r3 = bool4(false, false, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_less_equal_wide_scalar()
        {
            float4 a0 = float4(309.192444f, 69.67377f, -101.724182f, -315.9724f);
            float b0 = (292.924255f);
            bool4 r0 = bool4(false, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float4 a1 = float4(-346.011047f, -410.870056f, -483.902649f, 183.821167f);
            float b1 = (424.15387f);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float4 a2 = float4(320.4425f, -386.801758f, -182.938812f, 349.250122f);
            float b2 = (-257.870056f);
            bool4 r2 = bool4(false, true, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float4 a3 = float4(485.311584f, 259.1515f, 450.130066f, -128.525543f);
            float b3 = (373.5691f);
            bool4 r3 = bool4(false, true, false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_less_equal_scalar_wide()
        {
            float a0 = (-511.152374f);
            float4 b0 = float4(51.1589966f, 340.443665f, 312.81427f, 354.1925f);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float a1 = (136.396729f);
            float4 b1 = float4(-94.76788f, 288.5443f, 304.042847f, -148.618073f);
            bool4 r1 = bool4(false, true, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float a2 = (-506.3001f);
            float4 b2 = float4(27.5812378f, 48.47113f, 104.883484f, -488.685852f);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            float a3 = (-480.435181f);
            float4 b3 = float4(421.936646f, 239.721069f, -101.018433f, -283.951477f);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_greater_equal_wide_wide()
        {
            float4 a0 = float4(-386.5918f, -157.120789f, 391.015259f, -511.886871f);
            float4 b0 = float4(153.443f, 49.8924561f, 78.02582f, 138.813721f);
            bool4 r0 = bool4(false, false, true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            float4 a1 = float4(-5.42202759f, 287.645264f, -122.535187f, 7.48144531f);
            float4 b1 = float4(-225.51059f, -339.3561f, -373.302063f, 364.9359f);
            bool4 r1 = bool4(true, true, true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            float4 a2 = float4(152.946411f, 48.9862061f, 57.3381348f, 300.4649f);
            float4 b2 = float4(-322.7154f, 125.47821f, -25.77658f, 297.518921f);
            bool4 r2 = bool4(true, false, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float4 a3 = float4(349.25708f, 85.7496948f, -230.953308f, 418.711243f);
            float4 b3 = float4(73.22235f, 462.783752f, 393.191345f, -95.0014343f);
            bool4 r3 = bool4(true, false, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_greater_equal_wide_scalar()
        {
            float4 a0 = float4(495.4574f, -14.3451233f, -463.4748f, 217.517517f);
            float b0 = (189.205139f);
            bool4 r0 = bool4(true, false, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float4 a1 = float4(-246.865723f, 53.8151245f, -123.332947f, -221.505463f);
            float b1 = (-377.6587f);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float4 a2 = float4(252.994324f, -395.3633f, 164.772583f, -287.007324f);
            float b2 = (-116.440369f);
            bool4 r2 = bool4(true, false, true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float4 a3 = float4(355.837036f, 273.012268f, -418.1424f, 249.3841f);
            float b3 = (184.195557f);
            bool4 r3 = bool4(true, true, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_greater_equal_scalar_wide()
        {
            float a0 = (215.435364f);
            float4 b0 = float4(204.802979f, -101.104034f, -122.055023f, -70.45615f);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float a1 = (-239.62027f);
            float4 b1 = float4(-185.992737f, -455.612579f, 276.665833f, 79.39917f);
            bool4 r1 = bool4(false, true, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            float a2 = (416.420532f);
            float4 b2 = float4(379.2735f, -439.5147f, 67.14099f, -74.56064f);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float a3 = (-367.256348f);
            float4 b3 = float4(494.950745f, -61.2355347f, -429.170258f, -213.824677f);
            bool4 r3 = bool4(false, false, true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_add_wide_wide()
        {
            float4 a0 = float4(465.148376f, 278.9107f, -277.5299f, -65.1972046f);
            float4 b0 = float4(483.9944f, -204.07666f, -365.673553f, -509.920868f);
            float4 r0 = float4(949.142761f, 74.8340454f, -643.2035f, -575.118042f);
            TestUtils.AreEqual(a0 + b0, r0);

            float4 a1 = float4(-473.324371f, -4.69555664f, -470.536774f, -109.9501f);
            float4 b1 = float4(-270.6975f, 486.763977f, 267.49176f, 251.642517f);
            float4 r1 = float4(-744.021851f, 482.06842f, -203.045013f, 141.692413f);
            TestUtils.AreEqual(a1 + b1, r1);

            float4 a2 = float4(-178.701447f, -420.033783f, 290.711121f, -446.529633f);
            float4 b2 = float4(244.495117f, -78.67575f, 352.2055f, 82.7791748f);
            float4 r2 = float4(65.79367f, -498.709534f, 642.9166f, -363.750458f);
            TestUtils.AreEqual(a2 + b2, r2);

            float4 a3 = float4(491.066467f, -261.1173f, -298.4069f, 502.4286f);
            float4 b3 = float4(462.5473f, -405.492f, -428.498322f, -41.87259f);
            float4 r3 = float4(953.6138f, -666.6093f, -726.9052f, 460.556f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_add_wide_scalar()
        {
            float4 a0 = float4(459.898315f, -447.663361f, -94.43863f, 126.429871f);
            float b0 = (500.997253f);
            float4 r0 = float4(960.895569f, 53.3338928f, 406.558624f, 627.4271f);
            TestUtils.AreEqual(a0 + b0, r0);

            float4 a1 = float4(-36.254364f, -2.79125977f, -478.4148f, 443.115234f);
            float b1 = (-349.6413f);
            float4 r1 = float4(-385.89566f, -352.432556f, -828.0561f, 93.47394f);
            TestUtils.AreEqual(a1 + b1, r1);

            float4 a2 = float4(268.092224f, -471.256073f, -2.664978f, 78.98584f);
            float b2 = (41.3210449f);
            float4 r2 = float4(309.413269f, -429.935028f, 38.6560669f, 120.306885f);
            TestUtils.AreEqual(a2 + b2, r2);

            float4 a3 = float4(202.14801f, 10.3458252f, -151.244446f, 355.2328f);
            float b3 = (311.725464f);
            float4 r3 = float4(513.8735f, 322.0713f, 160.481018f, 666.958252f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_add_scalar_wide()
        {
            float a0 = (-325.512756f);
            float4 b0 = float4(-264.088135f, -106.009247f, -355.4473f, -447.3303f);
            float4 r0 = float4(-589.6009f, -431.522f, -680.9601f, -772.843f);
            TestUtils.AreEqual(a0 + b0, r0);

            float a1 = (-158.7002f);
            float4 b1 = float4(-199.4837f, 180.318115f, 337.579346f, -37.0550232f);
            float4 r1 = float4(-358.1839f, 21.61792f, 178.87915f, -195.755219f);
            TestUtils.AreEqual(a1 + b1, r1);

            float a2 = (230.805f);
            float4 b2 = float4(-140.174347f, 18.02417f, -138.614349f, 26.9041748f);
            float4 r2 = float4(90.6306458f, 248.829163f, 92.19064f, 257.709167f);
            TestUtils.AreEqual(a2 + b2, r2);

            float a3 = (-374.5376f);
            float4 b3 = float4(154.46759f, 268.38385f, -190.963013f, 188.617249f);
            float4 r3 = float4(-220.07f, -106.153748f, -565.5006f, -185.920349f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_sub_wide_wide()
        {
            float4 a0 = float4(133.371033f, -131.832123f, -197.293152f, -485.28656f);
            float4 b0 = float4(123.460266f, 359.56012f, -48.2484741f, 478.979065f);
            float4 r0 = float4(9.910767f, -491.392242f, -149.044678f, -964.2656f);
            TestUtils.AreEqual(a0 - b0, r0);

            float4 a1 = float4(-337.550323f, 471.6671f, 146.506592f, -130.585052f);
            float4 b1 = float4(207.158325f, 142.36731f, -125.6055f, -65.29901f);
            float4 r1 = float4(-544.7086f, 329.2998f, 272.1121f, -65.28604f);
            TestUtils.AreEqual(a1 - b1, r1);

            float4 a2 = float4(110.7771f, -235.5416f, 78.87933f, -347.686157f);
            float4 b2 = float4(-477.876434f, 164.5f, 428.009583f, 72.62781f);
            float4 r2 = float4(588.653564f, -400.0416f, -349.130249f, -420.313965f);
            TestUtils.AreEqual(a2 - b2, r2);

            float4 a3 = float4(-470.820557f, -11.45929f, -167.9479f, 330.676758f);
            float4 b3 = float4(-446.8805f, 432.091431f, -225.554657f, -112.451965f);
            float4 r3 = float4(-23.9400635f, -443.55072f, 57.60675f, 443.128723f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_sub_wide_scalar()
        {
            float4 a0 = float4(48.9367065f, 410.4516f, -364.4417f, 163.980591f);
            float b0 = (-291.5904f);
            float4 r0 = float4(340.5271f, 702.042f, -72.85132f, 455.570984f);
            TestUtils.AreEqual(a0 - b0, r0);

            float4 a1 = float4(-460.067322f, 204.358337f, 180.269714f, -377.9257f);
            float b1 = (110.919434f);
            float4 r1 = float4(-570.986755f, 93.4389f, 69.35028f, -488.845123f);
            TestUtils.AreEqual(a1 - b1, r1);

            float4 a2 = float4(-470.262054f, 461.507568f, -246.287262f, 21.6052856f);
            float b2 = (400.5349f);
            float4 r2 = float4(-870.797f, 60.9726563f, -646.822144f, -378.929626f);
            TestUtils.AreEqual(a2 - b2, r2);

            float4 a3 = float4(246.350708f, -122.718414f, -122.938721f, 360.15094f);
            float b3 = (-121.427368f);
            float4 r3 = float4(367.778076f, -1.29104614f, -1.51135254f, 481.5783f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_sub_scalar_wide()
        {
            float a0 = (294.5865f);
            float4 b0 = float4(452.352539f, 256.9898f, -275.159882f, -89.02753f);
            float4 r0 = float4(-157.766052f, 37.59668f, 569.746338f, 383.614f);
            TestUtils.AreEqual(a0 - b0, r0);

            float a1 = (488.2284f);
            float4 b1 = float4(-333.2173f, -64.233f, -66.04172f, 341.204956f);
            float4 r1 = float4(821.4457f, 552.4614f, 554.270142f, 147.023438f);
            TestUtils.AreEqual(a1 - b1, r1);

            float a2 = (-385.775055f);
            float4 b2 = float4(75.3947754f, 354.943726f, 169.131409f, 88.21661f);
            float4 r2 = float4(-461.16983f, -740.71875f, -554.9065f, -473.991669f);
            TestUtils.AreEqual(a2 - b2, r2);

            float a3 = (1.73498535f);
            float4 b3 = float4(122.538025f, -264.945f, -50.83719f, -347.65033f);
            float4 r3 = float4(-120.80304f, 266.68f, 52.5721741f, 349.3853f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_mul_wide_wide()
        {
            float4 a0 = float4(-394.780548f, -412.3722f, -25.8745728f, -241.045959f);
            float4 b0 = float4(-149.763977f, -345.04538f, -284.334045f, 267.979248f);
            float4 r0 = float4(59123.9063f, 142287.125f, 7357.022f, -64595.3164f);
            TestUtils.AreEqual(a0 * b0, r0);

            float4 a1 = float4(-93.6759949f, 244.159973f, 494.688477f, 53.5379639f);
            float4 b1 = float4(-326.6485f, -150.689667f, 207.732422f, 366.192871f);
            float4 r1 = float4(30599.123f, -36792.3867f, 102762.836f, 19605.22f);
            TestUtils.AreEqual(a1 * b1, r1);

            float4 a2 = float4(-239.4964f, 236.675842f, -211.8562f, -216.654816f);
            float4 b2 = float4(358.880737f, 214.853577f, 253.422791f, -307.7138f);
            float4 r2 = float4(-85950.64f, 50850.6523f, -53689.19f, 66667.68f);
            TestUtils.AreEqual(a2 * b2, r2);

            float4 a3 = float4(467.9583f, -178.021912f, -386.394257f, -422.4354f);
            float4 b3 = float4(184.47113f, 426.436462f, -144.281433f, 459.4796f);
            float4 r3 = float4(86324.8f, -75915.03f, 55749.5156f, -194100.453f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_mul_wide_scalar()
        {
            float4 a0 = float4(328.203f, -290.10672f, 236.995728f, 120.481384f);
            float b0 = (192.211182f);
            float4 r0 = float4(63084.2852f, -55761.7539f, 45553.23f, 23157.87f);
            TestUtils.AreEqual(a0 * b0, r0);

            float4 a1 = float4(357.903137f, -477.3105f, -438.272919f, -46.729187f);
            float b1 = (134.867249f);
            float4 r1 = float4(48269.41f, -64373.55f, -59108.6641f, -6302.237f);
            TestUtils.AreEqual(a1 * b1, r1);

            float4 a2 = float4(-238.405f, -48.83484f, 355.30835f, 119.356628f);
            float b2 = (422.08252f);
            float4 r2 = float4(-100626.586f, -20612.332f, 149969.438f, 50378.3477f);
            TestUtils.AreEqual(a2 * b2, r2);

            float4 a3 = float4(-196.995819f, -325.552155f, 53.9373169f, -87.45099f);
            float b3 = (98.23602f);
            float4 r3 = float4(-19352.0859f, -31980.95f, 5298.5874f, -8590.837f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_mul_scalar_wide()
        {
            float a0 = (-464.5347f);
            float4 b0 = float4(329.360962f, -198.683441f, 184.0794f, 256.016174f);
            float4 r0 = float4(-152999.6f, 92295.35f, -85511.27f, -118928.4f);
            TestUtils.AreEqual(a0 * b0, r0);

            float a1 = (266.226318f);
            float4 b1 = float4(-97.8947449f, 159.748108f, -351.8222f, 491.801575f);
            float4 r1 = float4(-26062.1582f, 42529.1523f, -93664.33f, 130930.523f);
            TestUtils.AreEqual(a1 * b1, r1);

            float a2 = (49.90204f);
            float4 b2 = float4(424.4626f, 160.1181f, -395.9921f, 125.20166f);
            float4 r2 = float4(21181.5488f, 7990.21973f, -19760.8125f, 6247.818f);
            TestUtils.AreEqual(a2 * b2, r2);

            float a3 = (-265.0158f);
            float4 b3 = float4(314.656128f, -292.712036f, -37.72989f, 165.362244f);
            float4 r3 = float4(-83388.85f, 77573.32f, 9999.017f, -43823.61f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_div_wide_wide()
        {
            float4 a0 = float4(246.265747f, -269.85614f, -451.619537f, -7.388489f);
            float4 b0 = float4(172.119812f, -77.14111f, -325.8354f, -450.608673f);
            float4 r0 = float4(1.43078089f, 3.49821424f, 1.38603592f, 0.0163966864f);
            TestUtils.AreEqual(a0 / b0, r0);

            float4 a1 = float4(-308.205566f, -373.3948f, 360.41864f, 25.8097534f);
            float4 b1 = float4(-261.262146f, -122.449493f, -93.2107849f, -442.005219f);
            float4 r1 = float4(1.17967939f, 3.04937816f, -3.86670542f, -0.0583924167f);
            TestUtils.AreEqual(a1 / b1, r1);

            float4 a2 = float4(-274.050476f, 127.538574f, -447.671753f, -137.458588f);
            float4 b2 = float4(484.362732f, -390.7818f, 402.02533f, 316.6507f);
            float4 r2 = float4(-0.565795958f, -0.326367736f, -1.11354113f, -0.434101641f);
            TestUtils.AreEqual(a2 / b2, r2);

            float4 a3 = float4(-136.133179f, 12.4376221f, 228.513f, 356.972351f);
            float4 b3 = float4(397.154419f, -303.2622f, -118.591248f, -81.6503f);
            float4 r3 = float4(-0.3427714f, -0.0410127677f, -1.926896f, -4.37196636f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_div_wide_scalar()
        {
            float4 a0 = float4(-244.517456f, 69.1123047f, -333.023132f, 257.396851f);
            float b0 = (-60.0243835f);
            float4 r0 = float4(4.07363558f, -1.15140378f, 5.548131f, -4.28820467f);
            TestUtils.AreEqual(a0 / b0, r0);

            float4 a1 = float4(403.2456f, 131.526611f, -261.8864f, -348.9238f);
            float b1 = (154.34436f);
            float4 r1 = float4(2.61263585f, 0.8521634f, -1.696767f, -2.26068377f);
            TestUtils.AreEqual(a1 / b1, r1);

            float4 a2 = float4(-275.5387f, 287.6424f, 504.372253f, 491.7871f);
            float b2 = (210.557922f);
            float4 r2 = float4(-1.30861235f, 1.36609626f, 2.39540863f, 2.335638f);
            TestUtils.AreEqual(a2 / b2, r2);

            float4 a3 = float4(-26.6315918f, 272.895142f, 178.096191f, -460.87558f);
            float b3 = (-253.236664f);
            float4 r3 = float4(0.105164833f, -1.07762885f, -0.7032797f, 1.81994021f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_div_scalar_wide()
        {
            float a0 = (41.73767f);
            float4 b0 = float4(-422.676147f, 248.129639f, 449.391357f, 245.858154f);
            float4 r0 = float4(-0.09874622f, 0.168209136f, 0.0928759947f, 0.169763222f);
            TestUtils.AreEqual(a0 / b0, r0);

            float a1 = (-326.6206f);
            float4 b1 = float4(163.715088f, 333.6645f, 38.2910767f, -472.979767f);
            float4 r1 = float4(-1.995055f, -0.978889346f, -8.529941f, 0.6905594f);
            TestUtils.AreEqual(a1 / b1, r1);

            float a2 = (192.230164f);
            float4 b2 = float4(-200.296875f, -490.181519f, -211.10257f, -322.852356f);
            float4 r2 = float4(-0.9597262f, -0.3921612f, -0.9106008f, -0.595412f);
            TestUtils.AreEqual(a2 / b2, r2);

            float a3 = (-137.985291f);
            float4 b3 = float4(84.32971f, 355.063477f, 276.427246f, -382.988037f);
            float4 r3 = float4(-1.63625944f, -0.388621479f, -0.499174f, 0.360286176f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_mod_wide_wide()
        {
            float4 a0 = float4(-442.309875f, 368.5005f, -1.09390259f, -364.673828f);
            float4 b0 = float4(-43.2450562f, -144.195862f, -62.6404724f, -336.828247f);
            float4 r0 = float4(-9.859314f, 80.1087646f, -1.09390259f, -27.8455811f);
            TestUtils.AreEqual(a0 % b0, r0);

            float4 a1 = float4(-197.343933f, -34.0349121f, -101.348572f, 208.318542f);
            float4 b1 = float4(-154.61026f, -154.029358f, 487.0462f, -469.8291f);
            float4 r1 = float4(-42.7336731f, -34.0349121f, -101.348572f, 208.318542f);
            TestUtils.AreEqual(a1 % b1, r1);

            float4 a2 = float4(-140.770325f, 183.44696f, -463.368378f, 83.83911f);
            float4 b2 = float4(-145.203766f, -203.384f, -22.52008f, 224.69f);
            float4 r2 = float4(-140.770325f, 183.44696f, -12.9667664f, 83.83911f);
            TestUtils.AreEqual(a2 % b2, r2);

            float4 a3 = float4(-64.71405f, 295.066833f, 212.25708f, 349.6283f);
            float4 b3 = float4(-435.62674f, 12.0955811f, 40.3787842f, 345.784851f);
            float4 r3 = float4(-64.71405f, 4.772888f, 10.3631592f, 3.84344482f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_mod_wide_scalar()
        {
            float4 a0 = float4(-433.417f, -5.51412964f, 393.3944f, 299.41156f);
            float b0 = (-90.49924f);
            float4 r0 = float4(-71.4200439f, -5.51412964f, 31.39746f, 27.9138489f);
            TestUtils.AreEqual(a0 % b0, r0);

            float4 a1 = float4(-120.80603f, -450.807678f, 186.094788f, -84.47363f);
            float b1 = (-502.939026f);
            float4 r1 = float4(-120.80603f, -450.807678f, 186.094788f, -84.47363f);
            TestUtils.AreEqual(a1 % b1, r1);

            float4 a2 = float4(-318.7815f, -54.60019f, -172.338867f, -429.714661f);
            float b2 = (433.4547f);
            float4 r2 = float4(-318.7815f, -54.60019f, -172.338867f, -429.714661f);
            TestUtils.AreEqual(a2 % b2, r2);

            float4 a3 = float4(222.361877f, 254.5108f, -433.0937f, -203.082611f);
            float b3 = (5.79638672f);
            float4 r3 = float4(2.09918213f, 5.26617432f, -4.161072f, -0.209075928f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_mod_scalar_wide()
        {
            float a0 = (-396.4224f);
            float4 b0 = float4(-159.140259f, 230.17334f, 14.7793579f, -303.1565f);
            float4 r0 = float4(-78.14188f, -166.249054f, -12.1590881f, -93.2659f);
            TestUtils.AreEqual(a0 % b0, r0);

            float a1 = (399.635f);
            float4 b1 = float4(206.6947f, 397.0448f, -393.890656f, -372.067078f);
            float4 r1 = float4(192.9403f, 2.59021f, 5.74435425f, 27.5679321f);
            TestUtils.AreEqual(a1 % b1, r1);

            float a2 = (201.012268f);
            float4 b2 = float4(-95.566864f, -258.951477f, 106.983582f, 469.323547f);
            float4 r2 = float4(9.87854f, 201.012268f, 94.02869f, 201.012268f);
            TestUtils.AreEqual(a2 % b2, r2);

            float a3 = (-34.80899f);
            float4 b3 = float4(184.836548f, 374.79425f, -131.872711f, -120.092865f);
            float4 r3 = float4(-34.80899f, -34.80899f, -34.80899f, -34.80899f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [TestCompiler]
        public static void float4_operator_plus()
        {
            float4 a0 = float4(271.670837f, -79.08023f, -330.985046f, 31.824707f);
            float4 r0 = float4(271.670837f, -79.08023f, -330.985046f, 31.824707f);
            TestUtils.AreEqual(+a0, r0);

            float4 a1 = float4(315.449524f, 190.324646f, -350.3086f, -320.518463f);
            float4 r1 = float4(315.449524f, 190.324646f, -350.3086f, -320.518463f);
            TestUtils.AreEqual(+a1, r1);

            float4 a2 = float4(102.054382f, -428.7762f, 377.230164f, 234.773926f);
            float4 r2 = float4(102.054382f, -428.7762f, 377.230164f, 234.773926f);
            TestUtils.AreEqual(+a2, r2);

            float4 a3 = float4(34.28363f, 465.355957f, 309.59314f, -316.937134f);
            float4 r3 = float4(34.28363f, 465.355957f, 309.59314f, -316.937134f);
            TestUtils.AreEqual(+a3, r3);
        }

        [TestCompiler]
        public static void float4_operator_neg()
        {
            float4 a0 = float4(420.227173f, -196.2575f, -335.426819f, 509.04364f);
            float4 r0 = float4(-420.227173f, 196.2575f, 335.426819f, -509.04364f);
            TestUtils.AreEqual(-a0, r0);

            float4 a1 = float4(-33.0144043f, -495.837952f, -270.859467f, 19.68689f);
            float4 r1 = float4(33.0144043f, 495.837952f, 270.859467f, -19.68689f);
            TestUtils.AreEqual(-a1, r1);

            float4 a2 = float4(268.2367f, 223.381287f, -410.392059f, -395.681549f);
            float4 r2 = float4(-268.2367f, -223.381287f, 410.392059f, 395.681549f);
            TestUtils.AreEqual(-a2, r2);

            float4 a3 = float4(-349.149475f, -238.2196f, 292.543518f, 469.2926f);
            float4 r3 = float4(349.149475f, 238.2196f, -292.543518f, -469.2926f);
            TestUtils.AreEqual(-a3, r3);
        }

        [TestCompiler]
        public static void float4_operator_prefix_inc()
        {
            float4 a0 = float4(-99.79556f, 458.741821f, 96.1790161f, -48.55246f);
            float4 r0 = float4(-98.79556f, 459.741821f, 97.1790161f, -47.55246f);
            TestUtils.AreEqual(++a0, r0);

            float4 a1 = float4(-315.728973f, -323.614868f, -456.8903f, -76.50766f);
            float4 r1 = float4(-314.728973f, -322.614868f, -455.8903f, -75.50766f);
            TestUtils.AreEqual(++a1, r1);

            float4 a2 = float4(-305.584778f, 148.679321f, 363.2849f, -115.559235f);
            float4 r2 = float4(-304.584778f, 149.679321f, 364.2849f, -114.559235f);
            TestUtils.AreEqual(++a2, r2);

            float4 a3 = float4(-326.8778f, 339.8766f, -38.41043f, -153.373688f);
            float4 r3 = float4(-325.8778f, 340.8766f, -37.41043f, -152.373688f);
            TestUtils.AreEqual(++a3, r3);
        }

        [TestCompiler]
        public static void float4_operator_postfix_inc()
        {
            float4 a0 = float4(322.943542f, 472.0525f, 203.48761f, -49.8545837f);
            float4 r0 = float4(322.943542f, 472.0525f, 203.48761f, -49.8545837f);
            TestUtils.AreEqual(a0++, r0);

            float4 a1 = float4(-31.4205322f, 271.454651f, 55.7368774f, 153.7503f);
            float4 r1 = float4(-31.4205322f, 271.454651f, 55.7368774f, 153.7503f);
            TestUtils.AreEqual(a1++, r1);

            float4 a2 = float4(-174.173f, 215.110229f, 159.861023f, -333.050446f);
            float4 r2 = float4(-174.173f, 215.110229f, 159.861023f, -333.050446f);
            TestUtils.AreEqual(a2++, r2);

            float4 a3 = float4(241.4649f, -170.104645f, -270.652466f, -162.86026f);
            float4 r3 = float4(241.4649f, -170.104645f, -270.652466f, -162.86026f);
            TestUtils.AreEqual(a3++, r3);
        }

        [TestCompiler]
        public static void float4_operator_prefix_dec()
        {
            float4 a0 = float4(-416.201233f, -96.63788f, -50.14566f, -207.316437f);
            float4 r0 = float4(-417.201233f, -97.63788f, -51.14566f, -208.316437f);
            TestUtils.AreEqual(--a0, r0);

            float4 a1 = float4(439.479065f, 337.968933f, 246.088989f, 171.964539f);
            float4 r1 = float4(438.479065f, 336.968933f, 245.088989f, 170.964539f);
            TestUtils.AreEqual(--a1, r1);

            float4 a2 = float4(-227.44281f, 326.5078f, 400.7209f, -478.031372f);
            float4 r2 = float4(-228.44281f, 325.5078f, 399.7209f, -479.031372f);
            TestUtils.AreEqual(--a2, r2);

            float4 a3 = float4(-326.452972f, 112.796875f, -341.9763f, -503.27417f);
            float4 r3 = float4(-327.452972f, 111.796875f, -342.9763f, -504.27417f);
            TestUtils.AreEqual(--a3, r3);
        }

        [TestCompiler]
        public static void float4_operator_postfix_dec()
        {
            float4 a0 = float4(-376.5924f, 16.9697266f, -0.2506714f, -202.323273f);
            float4 r0 = float4(-376.5924f, 16.9697266f, -0.2506714f, -202.323273f);
            TestUtils.AreEqual(a0--, r0);

            float4 a1 = float4(409.557556f, -281.1117f, -262.0626f, -182.405731f);
            float4 r1 = float4(409.557556f, -281.1117f, -262.0626f, -182.405731f);
            TestUtils.AreEqual(a1--, r1);

            float4 a2 = float4(450.1281f, -332.154968f, -261.0089f, 205.461121f);
            float4 r2 = float4(450.1281f, -332.154968f, -261.0089f, 205.461121f);
            TestUtils.AreEqual(a2--, r2);

            float4 a3 = float4(-230.227783f, 378.641235f, 487.344849f, -192.177856f);
            float4 r3 = float4(-230.227783f, 378.641235f, 487.344849f, -192.177856f);
            TestUtils.AreEqual(a3--, r3);
        }

        [TestCompiler]
        public static void float4_shuffle_result_1()
        {
            float4 a = float4(0, 1, 2, 3);
            float4 b = float4(4, 5, 6, 7);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX), (0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY), (1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ), (2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftW), (3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX), (4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY), (5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ), (6));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightW), (7));
        }

        [TestCompiler]
        public static void float4_shuffle_result_2()
        {
            float4 a = float4(0, 1, 2, 3);
            float4 b = float4(4, 5, 6, 7);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightZ), float2(5, 6));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightX), float2(6, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightX), float2(1, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightW, ShuffleComponent.LeftW), float2(7, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightW, ShuffleComponent.LeftZ), float2(7, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.LeftW), float2(2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftW), float2(5, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightW, ShuffleComponent.LeftX), float2(7, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightW), float2(6, 7));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftZ), float2(5, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightZ), float2(6, 6));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightW, ShuffleComponent.LeftX), float2(7, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX), float2(5, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightW, ShuffleComponent.RightY), float2(7, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX), float2(4, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftW), float2(1, 3));
        }

        [TestCompiler]
        public static void float4_shuffle_result_3()
        {
            float4 a = float4(0, 1, 2, 3);
            float4 b = float4(4, 5, 6, 7);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightW, ShuffleComponent.RightY), float3(2, 7, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftX, ShuffleComponent.LeftW), float3(6, 0, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightW, ShuffleComponent.RightX), float3(2, 7, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.LeftZ), float3(5, 0, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightW, ShuffleComponent.RightZ, ShuffleComponent.LeftZ), float3(7, 6, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftW, ShuffleComponent.LeftY, ShuffleComponent.LeftY), float3(3, 1, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftW, ShuffleComponent.RightY, ShuffleComponent.RightX), float3(3, 5, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftW, ShuffleComponent.LeftY, ShuffleComponent.RightW), float3(3, 1, 7));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightY, ShuffleComponent.RightZ), float3(6, 5, 6));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.LeftY), float3(5, 4, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightW, ShuffleComponent.RightW, ShuffleComponent.LeftX), float3(7, 7, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftY, ShuffleComponent.RightY), float3(6, 1, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftY, ShuffleComponent.RightW), float3(6, 1, 7));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftW, ShuffleComponent.RightY, ShuffleComponent.RightY), float3(3, 5, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftX, ShuffleComponent.RightY), float3(6, 0, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftY, ShuffleComponent.RightW), float3(5, 1, 7));
        }

        [TestCompiler]
        public static void float4_shuffle_result_4()
        {
            float4 a = float4(0, 1, 2, 3);
            float4 b = float4(4, 5, 6, 7);

            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.LeftW, ShuffleComponent.RightX, ShuffleComponent.LeftZ), float4(1, 3, 4, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftW, ShuffleComponent.RightZ, ShuffleComponent.RightZ), float4(5, 3, 6, 6));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightZ, ShuffleComponent.RightW, ShuffleComponent.LeftZ), float4(6, 6, 7, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightY, ShuffleComponent.LeftZ, ShuffleComponent.LeftZ), float4(4, 5, 2, 2));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.LeftY, ShuffleComponent.LeftY, ShuffleComponent.LeftX), float4(6, 1, 1, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightY, ShuffleComponent.RightY, ShuffleComponent.RightW), float4(4, 5, 5, 7));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftY, ShuffleComponent.RightW, ShuffleComponent.LeftX, ShuffleComponent.RightW), float4(1, 7, 0, 7));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.LeftX), float4(5, 0, 1, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.RightW, ShuffleComponent.LeftW, ShuffleComponent.LeftY), float4(4, 7, 3, 1));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightY, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightX), float4(5, 4, 1, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.LeftX), float4(0, 2, 6, 0));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightY, ShuffleComponent.RightW, ShuffleComponent.RightW), float4(2, 5, 7, 7));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftW, ShuffleComponent.RightX, ShuffleComponent.LeftZ, ShuffleComponent.RightX), float4(3, 4, 2, 4));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.LeftZ, ShuffleComponent.LeftW), float4(4, 0, 2, 3));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.RightZ, ShuffleComponent.RightX, ShuffleComponent.LeftX, ShuffleComponent.RightY), float4(6, 4, 0, 5));
            TestUtils.AreEqual(shuffle(a, b, ShuffleComponent.LeftW, ShuffleComponent.RightW, ShuffleComponent.LeftY, ShuffleComponent.RightY), float4(3, 7, 1, 5));
        }


    }
}