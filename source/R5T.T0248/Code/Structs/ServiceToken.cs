using System;

using R5T.T0142;


namespace R5T.T0248
{
    /// <summary>
    /// Allows instantiating a descriptor instance of a service.
    /// <para>
    /// For example, this type is useful for the parameters to service collection extension methods that add services;
    /// it allows communicating required dependency services as parameters, and added services as out parameters.
    /// These out parameters can in turn be used as the input parameters to dependent service addition methods.
    /// </para>
    /// </summary>
    /// <typeparam name="TService">The type of the service of interest.</typeparam>
    [UtilityTypeMarker]
    public struct ServiceToken<TService>
    {
    }
}
