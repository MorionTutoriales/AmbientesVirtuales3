#if !BESTHTTP_DISABLE_ALTERNATE_SSL && (!UNITY_WEBGL || UNITY_EDITOR)
#pragma warning disable
using System;
using Best.HTTP.SecureProtocol.Org.BouncyCastle.Utilities;

namespace Best.HTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests
{
    public class Gost3411_2012_512Digest:Gost3411_2012Digest
    {
		private readonly static byte[] IV = {
		0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
		0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
		0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
		0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
		0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
		0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
		0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
		0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
	};

		public override string AlgorithmName
		{
			get { return "GOST3411-2012-512"; }
		}

        public Gost3411_2012_512Digest():base(IV)
        {
        }

		public Gost3411_2012_512Digest(Gost3411_2012_512Digest other) : base(IV)
		{
            Reset(other);
        }

        public override int GetDigestSize()
        {
            return 64;
        }

		public override IMemoable Copy()
		{
			return new Gost3411_2012_512Digest(this);
		}
    }
}
#pragma warning restore
#endif
