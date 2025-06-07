int[] nums = { 3, 2, 4 };
int target = 6;

TwoSum(nums, target);

int[] TwoSum(int[] nums, int target)
{
    int[] indices = new int[2];
    int diff;
    int lastOccurrence;

    for (int i = 0; i < nums.Length; i++)
    {
        // Need to account for positive and negative values
        diff = target - nums[i];
        lastOccurrence = Array.LastIndexOf(nums, diff);

        if ((diff * 2 == target && lastOccurrence != i) || (diff * 2 != target && lastOccurrence > -1))
        {
            indices = [i, lastOccurrence];
            break;
        }
    }

    return indices;
}
