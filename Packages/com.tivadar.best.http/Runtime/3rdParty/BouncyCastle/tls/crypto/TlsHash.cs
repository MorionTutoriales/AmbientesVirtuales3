#if !BESTHTTP_DISABLE_ALTERNATE_SSL && (!UNITY_WEBGL || UNITY_EDITOR)
#pragma warning disable
using System;

namespace Best.HTTP.SecureProtocol.Org.BouncyCastle.Tls.Crypto
{
    /// <summary>Interface for message digest, or hash, services.</summary>
    public interface TlsHash
    {
        /// <summary>Update the hash with the passed in input.</summary>
        /// <param name="input">input array containing the data.</param>
        /// <param name="inOff">offset into the input array the input starts at.</param>
        /// <param name="length">the length of the input data.</param>
        void Update(byte[] input, int inOff, int length);

#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER || UNITY_2021_2_OR_NEWER
        void Update(ReadOnlySpan<byte> input);
#endif

        /// <summary>Return calculated hash for any input passed in.</summary>
        /// <returns>the hash value.</returns>
        byte[] CalculateHash();

        /// <summary>Return a clone of this hash object representing its current state.</summary>
        /// <returns>a clone of the current hash.</returns>
        TlsHash CloneHash();

        /// <summary>Reset the hash underlying this service.</summary>
        void Reset();
    }
}
#pragma warning restore
#endif
