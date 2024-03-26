using GenericTypes.Abstractions;
using GenericTypes.Model;

namespace GenericTypes.Infrastructure;

internal class InMemoryMeasureRepository : InMemoryEntityRepository<Measure>, IMeasureRepository
{

}