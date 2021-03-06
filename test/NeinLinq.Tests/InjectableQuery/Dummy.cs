﻿using System;
using System.Linq.Expressions;

namespace NeinLinq.Tests.InjectableQuery
{
    public class Dummy
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Distance { get; set; }

        public double Time { get; set; }

        [InjectLambda(nameof(InjectVelocityInternal))]
        public double VelocityInternal { get; }

        public double VelocityInternalWithGetter
        {
            [InjectLambda(nameof(InjectVelocityInternal))]
            get { throw new NotSupportedException(); }
        }

        public static Expression<Func<Dummy, double>> InjectVelocityInternal()
        {
            return v => v.Distance / v.Time;
        }

        [InjectLambda(typeof(DummyExtensions))]
        public double VelocityExternal { get; }

        public double VelocityExternalWithGetter
        {
            [InjectLambda(typeof(DummyExtensions), nameof(DummyExtensions.VelocityExternal))]
            get { throw new NotSupportedException(); }
        }

        public double VelocityWithConvention { get; }

        public static Expression<Func<Dummy, double>> VelocityWithConventionExpr => v => v.Distance / v.Time;

        [InjectLambda]
        public double VelocityWithMetadata { get; }

        public static Expression<Func<Dummy, double>> VelocityWithMetadataExpr => v => v.Distance / v.Time;

        public double VelocityWithoutSibling { get; }

        public double VelocityWithInvalidSiblingResult { get; }

        public static Func<Dummy, double> VelocityWithInvalidSiblingResultExpr => v => v.Distance / v.Time;

        public double VelocityWithInvalidSiblingSignature { get; }

        public static Expression<Func<double, double, double>> VelocityWithInvalidSiblingSignatureExpr => (d, t) => d / t;
    }
}
