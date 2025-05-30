﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
extern alias BaseShares;
extern alias DMShare;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Azure.Storage.Test;
using BaseShares::Azure.Storage.Files.Shares.Models;
using DMShare::Azure.Storage.DataMovement.Files.Shares;
using NUnit.Framework;
using Metadata = System.Collections.Generic.IDictionary<string, string>;

namespace Azure.Storage.DataMovement.Files.Shares.Tests
{
    public class ShareDestinationCheckpointDetailsTests
    {
        private const string DefaultContentType = "text/plain";
        private readonly string[] DefaultContentEncoding = new string[] { "gzip" };
        private readonly string[] DefaultContentLanguage = new string[] { "en-US" };
        private const string DefaultContentDisposition = "inline";
        private const string DefaultCacheControl = "no-cache";
        private readonly Metadata DefaultFileMetadata = new Dictionary<string, string>(DataProvider.BuildMetadata())
        {
            { "MetadataFor", "Files" }
        };
        private readonly Metadata DefaultDirectoryMetadata = new Dictionary<string, string>(DataProvider.BuildMetadata())
        {
            { "MetadataFor", "Directories" }
        };
        // just a few different flags, no meaning
        private readonly NtfsFileAttributes? DefaultFileAttributes = NtfsFileAttributes.Temporary | NtfsFileAttributes.Archive;
        private const string DefaultPermissions = "rwxrwxrwx";
        private const string DefaultFilePermissionKey = "MyPermissionKey";
        private readonly DateTimeOffset? DefaultFileCreatedOn = new DateTimeOffset(2019, 2, 19, 4, 3, 5, TimeSpan.FromMinutes(5));
        private readonly DateTimeOffset? DefaultFileLastWrittenOn = new DateTimeOffset(2024, 11, 24, 11, 23, 45, TimeSpan.FromHours(10));
        private readonly DateTimeOffset? DefaultFileChangedOn = new DateTimeOffset(2023, 12, 25, 12, 34, 56, TimeSpan.FromMinutes(11));

        private ShareFileDestinationCheckpointDetails CreateDefaultValues()
        => new ShareFileDestinationCheckpointDetails(
                false,
                default,
                false,
                default,
                false,
                default,
                false,
                default,
                false,
                default,
                false,
                default,
                default,
                false,
                default,
                false,
                default,
                false,
                default,
                false,
                default,
                false,
                default,
                ShareProtocol.Smb);

        private ShareFileDestinationCheckpointDetails CreateNoPreserveValues()
        => new ShareFileDestinationCheckpointDetails(
                true,
                default,
                true,
                default,
                true,
                default,
                true,
                default,
                true,
                default,
                true,
                default,
                default,
                true,
                default,
                true,
                default,
                true,
                default,
                true,
                default,
                true,
                default,
                ShareProtocol.Smb);

        private ShareFileDestinationCheckpointDetails CreatePreserveValues()
        => new ShareFileDestinationCheckpointDetails(
                false,
                default,
                false,
                default,
                false,
                default,
                false,
                default,
                false,
                default,
                false,
                default,
                true,
                false,
                default,
                false,
                default,
                false,
                default,
                false,
                default,
                false,
                default,
                ShareProtocol.Smb);

        private ShareFileDestinationCheckpointDetails CreateSetSampleValues()
        => new ShareFileDestinationCheckpointDetails(
                isContentTypeSet: true,
                contentType: DefaultContentType,
                isContentEncodingSet: true,
                contentEncoding: DefaultContentEncoding,
                isContentLanguageSet: true,
                contentLanguage: DefaultContentLanguage,
                isContentDispositionSet: true,
                contentDisposition: DefaultContentDisposition,
                isCacheControlSet: true,
                cacheControl: DefaultCacheControl,
                isFileAttributesSet: true,
                fileAttributes: DefaultFileAttributes,
                filePermissions: false,
                isFileCreatedOnSet: true,
                fileCreatedOn: DefaultFileCreatedOn,
                isFileLastWrittenOnSet: true,
                fileLastWrittenOn: DefaultFileLastWrittenOn,
                isFileChangedOnSet: true,
                fileChangedOn: DefaultFileChangedOn,
                isFileMetadataSet: true,
                fileMetadata: DefaultFileMetadata,
                isDirectoryMetadataSet: true,
                directoryMetadata: DefaultDirectoryMetadata,
                shareProtocol: ShareProtocol.Nfs);

        private void AssertEquals(ShareFileDestinationCheckpointDetails left, ShareFileDestinationCheckpointDetails right)
        {
            Assert.That(left.Version, Is.EqualTo(right.Version));

            Assert.That(left.IsFileAttributesSet, Is.EqualTo(right.IsFileAttributesSet));
            if (left.IsFileAttributesSet && left.FileAttributes != default)
            {
                Assert.That(left.FileAttributes, Is.EqualTo(right.FileAttributes));
            }

            Assert.That(left.FilePermission, Is.EqualTo(right.FilePermission));
            Assert.That(left.IsFileCreatedOnSet, Is.EqualTo(right.IsFileCreatedOnSet));
            if (!left.IsFileCreatedOnSet && left.FileCreatedOn != default)
            {
                Assert.That(left.FileCreatedOn, Is.EqualTo(right.FileCreatedOn));
            }

            Assert.That(left.IsFileLastWrittenOnSet, Is.EqualTo(right.IsFileLastWrittenOnSet));
            if (!left.IsFileLastWrittenOnSet && left.FileLastWrittenOn != default)
            {
                Assert.That(left.FileLastWrittenOn, Is.EqualTo(right.FileLastWrittenOn));
            }

            Assert.That(left.IsFileChangedOnSet, Is.EqualTo(right.IsFileChangedOnSet));
            if (!left.IsFileChangedOnSet && left.FileChangedOn != default)
            {
                Assert.That(left.FileChangedOn, Is.EqualTo(right.FileChangedOn));
            }

            Assert.That(left.IsContentTypeSet, Is.EqualTo(right.IsContentTypeSet));
            if (!left.IsContentTypeSet && left.ContentType != default)
            {
                Assert.That(left.ContentType, Is.EqualTo(right.ContentType));
            }

            Assert.That(left.IsContentEncodingSet, Is.EqualTo(right.IsContentEncodingSet));
            if (!left.IsContentEncodingSet && left.ContentEncoding != default)
            {
                Assert.That(left.ContentEncoding, Is.EqualTo(right.ContentEncoding));
            }

            Assert.That(left.IsContentLanguageSet, Is.EqualTo(right.IsContentLanguageSet));
            if (!left.IsContentLanguageSet && left.ContentLanguage != default)
            {
                Assert.That(left.ContentLanguage, Is.EqualTo(right.ContentLanguage));
            }

            Assert.That(left.IsContentDispositionSet, Is.EqualTo(right.IsContentDispositionSet));
            if (!left.IsContentDispositionSet && left.ContentDisposition != default)
            {
                Assert.That(left.ContentDisposition, Is.EqualTo(right.ContentDisposition));
            }

            Assert.That(left.IsCacheControlSet, Is.EqualTo(right.IsCacheControlSet));
            if (!left.IsCacheControlSet && left.CacheControl != default)
            {
                Assert.That(left.CacheControl, Is.EqualTo(right.CacheControl));
            }

            Assert.That(left.IsFileMetadataSet, Is.EqualTo(right.IsFileMetadataSet));
            if (!left.IsFileMetadataSet && left.FileMetadata != default && left.FileMetadata.Count > 0)
            {
                Assert.That(left.FileMetadata, Is.EqualTo(right.FileMetadata));
            }

            Assert.That(left.IsDirectoryMetadataSet, Is.EqualTo(right.IsDirectoryMetadataSet));
            if (!left.IsDirectoryMetadataSet && left.DirectoryMetadata != default && left.DirectoryMetadata.Count > 0)
            {
                Assert.That(left.DirectoryMetadata, Is.EqualTo(right.DirectoryMetadata));
            }

            Assert.That(left.ShareProtocol, Is.EqualTo(right.ShareProtocol));
        }

        private byte[] CreateSerializedPreserve()
        {
            using MemoryStream stream = new();
            using BinaryWriter writer = new(stream);

            int currentVariableLengthIndex = DataMovementShareConstants.DestinationCheckpointDetails.VariableLengthStartIndex;
            writer.Write(DataMovementShareConstants.DestinationCheckpointDetails.SchemaVersion);
            writer.WritePreservablePropertyOffset(false, DataMovementConstants.IntSizeInBytes, ref currentVariableLengthIndex);
            writer.Write(true);
            writer.WritePreservablePropertyOffset(false, 0, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(false, 0, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(false, 0, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(false, 0, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(false, 0, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(false, 0, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(false, 0, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(false, 0, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(false, 0, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(false, 0, ref currentVariableLengthIndex);
            writer.Write((byte)ShareProtocol.Smb);

            return stream.ToArray();
        }

        private byte[] CreateSerializedNoPreserve()
        {
            using MemoryStream stream = new();
            using BinaryWriter writer = new(stream);

            int currentVariableLengthIndex = DataMovementShareConstants.DestinationCheckpointDetails.VariableLengthStartIndex;
            writer.Write(DataMovementShareConstants.DestinationCheckpointDetails.SchemaVersion);
            writer.WritePreservablePropertyOffset(true, 0, ref currentVariableLengthIndex);
            writer.Write(false);
            writer.WritePreservablePropertyOffset(true, 0, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(true, 0, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(true, 0, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(true, 0, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(true, 0, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(true, 0, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(true, 0, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(true, 0, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(true, 0, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(true, 0, ref currentVariableLengthIndex);
            writer.Write((byte)ShareProtocol.Smb);

            return stream.ToArray();
        }

        private byte[] CreateSerializedSetValues_LatestVersion()
        {
            using MemoryStream stream = new();
            using BinaryWriter writer = new(stream);

            bool preserveFilePermission = false;
            byte[] fileCreatedOn = Encoding.UTF8.GetBytes(DefaultFileCreatedOn.Value.ToString("o"));
            byte[] fileLastWrittenOn = Encoding.UTF8.GetBytes(DefaultFileLastWrittenOn.Value.ToString("o"));
            byte[] fileChangedOn = Encoding.UTF8.GetBytes(DefaultFileChangedOn.Value.ToString("o"));
            byte[] contentType = Encoding.UTF8.GetBytes(DefaultContentType);
            byte[] contentEncoding = Encoding.UTF8.GetBytes(string.Join(",", DefaultContentEncoding));
            byte[] contentLanguage = Encoding.UTF8.GetBytes(string.Join(",", DefaultContentLanguage));
            byte[] contentDisposition = Encoding.UTF8.GetBytes(DefaultContentDisposition);
            byte[] cacheControl = Encoding.UTF8.GetBytes(DefaultCacheControl);
            byte[] fileMetadata = Encoding.UTF8.GetBytes(DefaultFileMetadata.DictionaryToString());
            byte[] directoryMetadata = Encoding.UTF8.GetBytes(DefaultDirectoryMetadata.DictionaryToString());

            int currentVariableLengthIndex = DataMovementShareConstants.DestinationCheckpointDetails.VariableLengthStartIndex;
            writer.Write(DataMovementShareConstants.DestinationCheckpointDetails.SchemaVersion);
            writer.WritePreservablePropertyOffset(true, DataMovementConstants.IntSizeInBytes, ref currentVariableLengthIndex);
            writer.Write(preserveFilePermission);
            writer.WritePreservablePropertyOffset(true, fileCreatedOn.Length, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(true, fileLastWrittenOn.Length, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(true, fileChangedOn.Length, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(true, contentType.Length, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(true, contentEncoding.Length, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(true, contentLanguage.Length, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(true, contentDisposition.Length, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(true, cacheControl.Length, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(true, fileMetadata.Length, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(true, directoryMetadata.Length, ref currentVariableLengthIndex);
            writer.Write((byte)ShareProtocol.Nfs);
            writer.Write((int)DefaultFileAttributes);
            writer.Write(fileCreatedOn);
            writer.Write(fileLastWrittenOn);
            writer.Write(fileChangedOn);
            writer.Write(contentType);
            writer.Write(contentEncoding);
            writer.Write(contentLanguage);
            writer.Write(contentDisposition);
            writer.Write(cacheControl);
            writer.Write(fileMetadata);
            writer.Write(directoryMetadata);

            return stream.ToArray();
        }

        private byte[] CreateSerializedSetValues_Version3()
        {
            using MemoryStream stream = new();
            using BinaryWriter writer = new(stream);

            bool preserveFilePermission = false;
            byte[] fileCreatedOn = Encoding.UTF8.GetBytes(DefaultFileCreatedOn.Value.ToString("o"));
            byte[] fileLastWrittenOn = Encoding.UTF8.GetBytes(DefaultFileLastWrittenOn.Value.ToString("o"));
            byte[] fileChangedOn = Encoding.UTF8.GetBytes(DefaultFileChangedOn.Value.ToString("o"));
            byte[] contentType = Encoding.UTF8.GetBytes(DefaultContentType);
            byte[] contentEncoding = Encoding.UTF8.GetBytes(string.Join(",", DefaultContentEncoding));
            byte[] contentLanguage = Encoding.UTF8.GetBytes(string.Join(",", DefaultContentLanguage));
            byte[] contentDisposition = Encoding.UTF8.GetBytes(DefaultContentDisposition);
            byte[] cacheControl = Encoding.UTF8.GetBytes(DefaultCacheControl);
            byte[] fileMetadata = Encoding.UTF8.GetBytes(DefaultFileMetadata.DictionaryToString());
            byte[] directoryMetadata = Encoding.UTF8.GetBytes(DefaultDirectoryMetadata.DictionaryToString());

            int currentVariableLengthIndex = DataMovementShareConstants.DestinationCheckpointDetails.VariableLengthStartIndex;
            writer.Write(DataMovementShareConstants.DestinationCheckpointDetails.SchemaVersion_3);
            writer.WritePreservablePropertyOffset(true, DataMovementConstants.IntSizeInBytes, ref currentVariableLengthIndex);
            writer.Write(preserveFilePermission);
            writer.WritePreservablePropertyOffset(true, fileCreatedOn.Length, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(true, fileLastWrittenOn.Length, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(true, fileChangedOn.Length, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(true, contentType.Length, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(true, contentEncoding.Length, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(true, contentLanguage.Length, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(true, contentDisposition.Length, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(true, cacheControl.Length, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(true, fileMetadata.Length, ref currentVariableLengthIndex);
            writer.WritePreservablePropertyOffset(true, directoryMetadata.Length, ref currentVariableLengthIndex);
            writer.Write((byte)ShareProtocol.Nfs);
            writer.Write((int)DefaultFileAttributes);
            writer.Write(fileCreatedOn);
            writer.Write(fileLastWrittenOn);
            writer.Write(fileChangedOn);
            writer.Write(contentType);
            writer.Write(contentEncoding);
            writer.Write(contentLanguage);
            writer.Write(contentDisposition);
            writer.Write(cacheControl);
            writer.Write(fileMetadata);
            writer.Write(directoryMetadata);

            return stream.ToArray();
        }

        [Test]
        public void Ctor()
        {
            ShareFileDestinationCheckpointDetails data = CreateDefaultValues();

            Assert.AreEqual(DataMovementShareConstants.DestinationCheckpointDetails.SchemaVersion, data.Version);
            Assert.IsFalse(data.IsFileAttributesSet);
            Assert.IsNull(data.FileAttributes);
            Assert.IsFalse(data.FilePermission);
            Assert.IsFalse(data.IsFileCreatedOnSet);
            Assert.IsNull(data.FileCreatedOn);
            Assert.IsFalse(data.IsFileLastWrittenOnSet);
            Assert.IsNull(data.FileLastWrittenOn);
            Assert.IsFalse(data.IsFileChangedOnSet);
            Assert.IsNull(data.FileChangedOn);
            Assert.IsFalse(data.IsContentTypeSet);
            Assert.IsEmpty(data.ContentTypeBytes);
            Assert.IsFalse(data.IsContentEncodingSet);
            Assert.IsEmpty(data.ContentEncodingBytes);
            Assert.IsFalse(data.IsContentLanguageSet);
            Assert.IsEmpty(data.ContentLanguageBytes);
            Assert.IsFalse(data.IsContentDispositionSet);
            Assert.IsEmpty(data.ContentDispositionBytes);
            Assert.IsFalse(data.IsCacheControlSet);
            Assert.IsEmpty(data.CacheControlBytes);
            Assert.IsFalse(data.IsFileMetadataSet);
            Assert.IsNull(data.FileMetadata);
            Assert.IsFalse(data.IsDirectoryMetadataSet);
            Assert.IsNull(data.DirectoryMetadata);
            Assert.That(ShareProtocol.Smb, Is.EqualTo(data.ShareProtocol));
        }

        [Test]
        public void Ctor_SetValues()
        {
            ShareFileDestinationCheckpointDetails data = CreateSetSampleValues();

            Assert.That(data.Version, Is.EqualTo(DataMovementShareConstants.DestinationCheckpointDetails.SchemaVersion));
            Assert.IsTrue(data.IsFileAttributesSet);
            Assert.That(data.FileAttributes, Is.EqualTo(DefaultFileAttributes));
            Assert.IsFalse(data.FilePermission);
            Assert.IsTrue(data.IsFileCreatedOnSet);
            Assert.That(data.FileCreatedOn.Value, Is.EqualTo(DefaultFileCreatedOn));
            Assert.IsTrue(data.IsFileLastWrittenOnSet);
            Assert.That(data.FileLastWrittenOn.Value, Is.EqualTo(DefaultFileLastWrittenOn));
            Assert.IsTrue(data.IsFileChangedOnSet);
            Assert.That(data.FileChangedOn.Value, Is.EqualTo(DefaultFileChangedOn));
            Assert.IsTrue(data.IsContentTypeSet);
            Assert.That(data.ContentType, Is.EqualTo(DefaultContentType));
            Assert.IsTrue(data.IsContentEncodingSet);
            Assert.That(data.ContentEncoding, Is.EqualTo(DefaultContentEncoding));
            Assert.IsTrue(data.IsContentLanguageSet);
            Assert.That(data.ContentLanguage, Is.EqualTo(DefaultContentLanguage));
            Assert.IsTrue(data.IsContentDispositionSet);
            Assert.That(data.ContentDisposition, Is.EqualTo(DefaultContentDisposition));
            Assert.IsTrue(data.IsCacheControlSet);
            Assert.That(data.CacheControl, Is.EqualTo(DefaultCacheControl));
            Assert.IsTrue(data.IsFileMetadataSet);
            Assert.That(data.FileMetadata, Is.EqualTo(DefaultFileMetadata));
            Assert.IsTrue(data.IsDirectoryMetadataSet);
            Assert.That(data.DirectoryMetadata, Is.EqualTo(DefaultDirectoryMetadata));
            Assert.That(data.ShareProtocol, Is.EqualTo(ShareProtocol.Nfs));
        }

        [Test]
        public void Ctor_Preserve()
        {
            ShareFileDestinationCheckpointDetails data = CreatePreserveValues();

            Assert.AreEqual(DataMovementShareConstants.DestinationCheckpointDetails.SchemaVersion, data.Version);
            Assert.IsFalse(data.IsFileAttributesSet);
            Assert.IsNull(data.FileAttributes);
            Assert.IsTrue(data.FilePermission);
            Assert.IsFalse(data.IsFileCreatedOnSet);
            Assert.IsNull(data.FileCreatedOn);
            Assert.IsFalse(data.IsFileLastWrittenOnSet);
            Assert.IsNull(data.FileLastWrittenOn);
            Assert.IsFalse(data.IsFileChangedOnSet);
            Assert.IsNull(data.FileChangedOn);
            Assert.IsFalse(data.IsContentTypeSet);
            Assert.IsNull(data.ContentType);
            Assert.IsFalse(data.IsContentEncodingSet);
            Assert.IsNull(data.ContentEncoding);
            Assert.IsFalse(data.IsContentLanguageSet);
            Assert.IsNull(data.ContentLanguage);
            Assert.IsFalse(data.IsContentDispositionSet);
            Assert.IsNull(data.ContentDisposition);
            Assert.IsFalse(data.IsCacheControlSet);
            Assert.IsNull(data.CacheControl);
            Assert.IsFalse(data.IsFileMetadataSet);
            Assert.IsNull(data.FileMetadata);
            Assert.IsFalse(data.IsDirectoryMetadataSet);
            Assert.IsNull(data.DirectoryMetadata);
            Assert.That(ShareProtocol.Smb, Is.EqualTo(data.ShareProtocol));
        }

        [Test]
        public void Serialize_LatestVersion()
        {
            byte[] expected = CreateSerializedSetValues_LatestVersion();

            ShareFileDestinationCheckpointDetails data = CreateSetSampleValues();
            byte[] actual;
            using (MemoryStream stream = new())
            {
                data.SerializeInternal(stream);
                actual = stream.ToArray();
            }

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Deserialize_LatestVersion()
        {
            byte[] serialized = CreateSerializedSetValues_LatestVersion();
            ShareFileDestinationCheckpointDetails deserialized;

            using (MemoryStream stream = new(serialized))
            {
                deserialized = ShareFileDestinationCheckpointDetails.Deserialize(stream);
            }

            AssertEquals(deserialized, CreateSetSampleValues());
        }

        [Test]
        public void Deserialize_Version3()
        {
            byte[] serialized = CreateSerializedSetValues_Version3();
            ShareFileDestinationCheckpointDetails expected = CreateSetSampleValues();
            expected.ShareProtocol = ShareProtocol.Smb;

            ShareFileDestinationCheckpointDetails deserialized;
            using (MemoryStream stream = new(serialized))
            {
                deserialized = ShareFileDestinationCheckpointDetails.Deserialize(stream);
            }

            // When deserializing, Version gets bumped to the latest version and ShareProtocol is set to default value (SMB)
            AssertEquals(deserialized, expected);
            // We are expecting that after deserialization, the version is bumped to latest version
            Assert.That(deserialized.Version, Is.EqualTo(DataMovementShareConstants.DestinationCheckpointDetails.SchemaVersion));
            // We are expecting that after deserialization, the ShareProtocol is set to default value (SMB)
            Assert.That(deserialized.ShareProtocol, Is.EqualTo(ShareProtocol.Smb));
        }

        [Test]
        public void Deserialize_Preserve()
        {
            byte[] serialized = CreateSerializedPreserve();
            ShareFileDestinationCheckpointDetails deserialized;

            using (MemoryStream stream = new(serialized))
            {
                deserialized = ShareFileDestinationCheckpointDetails.Deserialize(stream);
            }

            AssertEquals(deserialized, CreatePreserveValues());
        }

        [Test]
        public void Deserialize_NoPreserve()
        {
            byte[] serialized = CreateSerializedNoPreserve();
            ShareFileDestinationCheckpointDetails deserialized;

            using (MemoryStream stream = new(serialized))
            {
                deserialized = ShareFileDestinationCheckpointDetails.Deserialize(stream);
            }

            AssertEquals(deserialized, CreateNoPreserveValues());
        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(5)]
        [TestCase(9)]
        public void Deserialize_IncorrectSchemaVersion(int incorrectSchemaVersion)
        {
            ShareFileDestinationCheckpointDetails data = CreatePreserveValues();
            data.Version = incorrectSchemaVersion;

            using MemoryStream dataStream = new MemoryStream(DataMovementShareConstants.DestinationCheckpointDetails.VariableLengthStartIndex);
            data.SerializeInternal(dataStream);
            dataStream.Position = 0;
            TestHelper.AssertExpectedException(
                () => ShareFileDestinationCheckpointDetails.Deserialize(dataStream),
                new ArgumentException($"The checkpoint file schema version {incorrectSchemaVersion} is not supported by this version of the SDK."));
        }

        [Test]
        public void RoundTrip_LatestVersion()
        {
            ShareFileDestinationCheckpointDetails original = CreateSetSampleValues();
            using MemoryStream serialized = new();
            original.SerializeInternal(serialized);
            serialized.Position = 0;
            ShareFileDestinationCheckpointDetails deserialized = ShareFileDestinationCheckpointDetails.Deserialize(serialized);

            AssertEquals(original, deserialized);
        }

        [Test]
        public void RoundTrip_Version3()
        {
            ShareFileDestinationCheckpointDetails original = CreateSetSampleValues();
            original.Version = DataMovementShareConstants.DestinationCheckpointDetails.SchemaVersion_3;
            using MemoryStream serialized = new();
            original.SerializeInternal(serialized);
            serialized.Position = 0;
            ShareFileDestinationCheckpointDetails deserialized = ShareFileDestinationCheckpointDetails.Deserialize(serialized);

            // During round trip when deserializing, Version gets bumped to the latest version
            Assert.That(original.Version, Is.Not.EqualTo(deserialized.Version));
            Assert.That(deserialized.Version, Is.EqualTo(DataMovementShareConstants.DestinationCheckpointDetails.SchemaVersion_4));
            Assert.That(original.IsFileAttributesSet, Is.EqualTo(deserialized.IsFileAttributesSet));
            Assert.That(original.FileAttributes, Is.EqualTo(deserialized.FileAttributes));
            Assert.That(original.FilePermission, Is.EqualTo(deserialized.FilePermission));
            Assert.That(original.IsFileCreatedOnSet, Is.EqualTo(deserialized.IsFileCreatedOnSet));
            Assert.That(original.FileCreatedOn.Value, Is.EqualTo(deserialized.FileCreatedOn.Value));
            Assert.That(original.IsFileLastWrittenOnSet, Is.EqualTo(deserialized.IsFileLastWrittenOnSet));
            Assert.That(original.FileLastWrittenOn.Value, Is.EqualTo(deserialized.FileLastWrittenOn.Value));
            Assert.That(original.IsFileChangedOnSet, Is.EqualTo(deserialized.IsFileChangedOnSet));
            Assert.That(original.FileChangedOn.Value, Is.EqualTo(deserialized.FileChangedOn.Value));
            Assert.That(original.IsContentTypeSet, Is.EqualTo(deserialized.IsContentTypeSet));
            Assert.That(original.ContentType, Is.EqualTo(deserialized.ContentType));
            Assert.That(original.IsContentEncodingSet, Is.EqualTo(deserialized.IsContentEncodingSet));
            Assert.That(original.ContentEncoding, Is.EqualTo(deserialized.ContentEncoding));
            Assert.That(original.IsContentLanguageSet, Is.EqualTo(deserialized.IsContentLanguageSet));
            Assert.That(original.ContentLanguage, Is.EqualTo(deserialized.ContentLanguage));
            Assert.That(original.IsContentDispositionSet, Is.EqualTo(deserialized.IsContentDispositionSet));
            Assert.That(original.ContentDisposition, Is.EqualTo(deserialized.ContentDisposition));
            Assert.That(original.IsCacheControlSet, Is.EqualTo(deserialized.IsCacheControlSet));
            Assert.That(original.CacheControl, Is.EqualTo(deserialized.CacheControl));
            Assert.That(original.IsFileMetadataSet, Is.EqualTo(deserialized.IsFileMetadataSet));
            Assert.That(original.FileMetadata, Is.EqualTo(deserialized.FileMetadata));
            Assert.That(original.IsDirectoryMetadataSet, Is.EqualTo(deserialized.IsDirectoryMetadataSet));
            Assert.That(original.DirectoryMetadata, Is.EqualTo(deserialized.DirectoryMetadata));
            // From version 3, the ShareProtocol does not get copied over so it is set to default value of SMB.
            Assert.That(original.ShareProtocol, Is.Not.EqualTo(deserialized.ShareProtocol));
            Assert.That(deserialized.ShareProtocol, Is.EqualTo(ShareProtocol.Smb));
        }
    }
}
