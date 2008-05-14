using System;



namespace Topology.Geometries
{
    /// <summary>
    /// Creates CoordinateSequences internally represented
    /// as an array of x's and an array of y's.
    /// </summary>
    [Serializable]
    [Obsolete("No longer used")]
    public class DefaultCoordinateSequenceFactory : ICoordinateSequenceFactory
    {
        // NOTE: modified for "safe" assembly in Sql 2005
        // Readonly added
        private static readonly DefaultCoordinateSequenceFactory instance = new DefaultCoordinateSequenceFactory();

        /// <summary>
        /// 
        /// </summary>
        private DefaultCoordinateSequenceFactory() { }

        // see http://www.javaworld.com/javaworld/javatips/jw-javatip122.html
        private object ReadResolve()
        {
            return DefaultCoordinateSequenceFactory.Instance;
        }

        /// <summary>
        /// Returns the singleton instance of DefaultCoordinateSequenceFactory.
        /// </summary>
        /// <returns>Singleton instance of DefaultCoordinateSequenceFactory.</returns>
        public static DefaultCoordinateSequenceFactory Instance
        {
            get
            {
                return instance;
            }
        }

        /// <summary>
        /// Returns a DefaultCoordinateSequence based on the given array
        /// (the array is not copied).
        /// </summary>
        /// <param name="coordinates">Coordinates array, which may not be null
        /// nor contain null elements</param>
        /// <returns>Singleton instance of DefaultCoordinateSequenceFactory.</returns>
        public ICoordinateSequence Create(ICoordinate[] coordinates)
        {
            return new DefaultCoordinateSequence(coordinates);
        }
    }
}
