\
\ @file sai2.fs
\ @brief SAI2 global interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Global configuration register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000003 constant SAI2_SAI_GCR_SYNCIN                              \ Synchronization inputs
$00000030 constant SAI2_SAI_GCR_SYNCOUT                             \ Synchronization outputs These bits are set and cleared by software.


\
\ @brief Configuration register 1
\ Address offset: 0x04
\ Reset value: 0x00000040
\

$00000003 constant SAI2_SAI_ACR1_MODE                               \ SAIx audio block mode immediately
$0000000c constant SAI2_SAI_ACR1_PRTCFG                             \ Protocol configuration. These bits are set and cleared by software. These bits have to be configured when the audio block is disabled.
$000000e0 constant SAI2_SAI_ACR1_DS                                 \ Data size. These bits are set and cleared by software. These bits are ignored when the SPDIF protocols are selected (bit PRTCFG[1:0]), because the frame and the data size are fixed in such case. When the companding mode is selected through COMP[1:0] bits, DS[1:0] are ignored since the data size is fixed to 8 bits by the algorithm. These bits must be configured when the audio block is disabled.
$00000100 constant SAI2_SAI_ACR1_LSBFIRST                           \ Least significant bit first. This bit is set and cleared by software. It must be configured when the audio block is disabled. This bit has no meaning in AC97 audio protocol since AC97 data are always transferred with the MSB first. This bit has no meaning in SPDIF audio protocol since in SPDIF data are always transferred with LSB first.
$00000200 constant SAI2_SAI_ACR1_CKSTR                              \ Clock strobing edge. This bit is set and cleared by software. It must be configured when the audio block is disabled. This bit has no meaning in SPDIF audio protocol.
$00000c00 constant SAI2_SAI_ACR1_SYNCEN                             \ Synchronization enable. These bits are set and cleared by software. They must be configured when the audio sub-block is disabled. Note: The audio sub-block should be configured as asynchronous when SPDIF mode is enabled.
$00001000 constant SAI2_SAI_ACR1_MONO                               \ Mono mode. This bit is set and cleared by software. It is meaningful only when the number of slots is equal to 2. When the mono mode is selected, slot 0 data are duplicated on slot 1 when the audio block operates as a transmitter. In reception mode, the slot1 is discarded and only the data received from slot 0 are stored. Refer to Section: Mono/stereo mode for more details.
$00002000 constant SAI2_SAI_ACR1_OUTDRIV                            \ Output drive. This bit is set and cleared by software. Note: This bit has to be set before enabling the audio block and after the audio block configuration.
$00010000 constant SAI2_SAI_ACR1_SAIXEN                             \ Audio block enable where x is A or B. This bit is set by software. To switch off the audio block, the application software must program this bit to 0 and poll the bit till it reads back 0, meaning that the block is completely disabled. Before setting this bit to 1, check that it is set to 0, otherwise the enable command will not be taken into account. This bit allows to control the state of SAIx audio block. If it is disabled when an audio frame transfer is ongoing, the ongoing transfer completes and the cell is fully disabled at the end of this audio frame transfer. Note: When SAIx block is configured in master mode, the clock must be present on the input of SAIx before setting SAIXEN bit.
$00020000 constant SAI2_SAI_ACR1_DMAEN                              \ DMA enable. This bit is set and cleared by software. Note: Since the audio block defaults to operate as a transmitter after reset, the MODE[1:0] bits must be configured before setting DMAEN to avoid a DMA request in receiver mode.
$00080000 constant SAI2_SAI_ACR1_NOMCK                              \ No divider
$00f00000 constant SAI2_SAI_ACR1_MCKDIV                             \ Master clock divider. These bits are set and cleared by software. These bits are meaningless when the audio block operates in slave mode. They have to be configured when the audio block is disabled. Others: the master clock frequency is calculated accordingly to the following formula:
$04000000 constant SAI2_SAI_ACR1_OSR                                \ Oversampling ratio for master clock


\
\ @brief Configuration register 2
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant SAI2_SAI_ACR2_FTH                                \ FIFO threshold. This bit is set and cleared by software.
$00000008 constant SAI2_SAI_ACR2_FFLUSH                             \ FIFO flush. This bit is set by software. It is always read as 0. This bit should be configured when the SAI is disabled.
$00000010 constant SAI2_SAI_ACR2_TRIS                               \ Tristate management on data line. This bit is set and cleared by software. It is meaningful only if the audio block is configured as a transmitter. This bit is not used when the audio block is configured in SPDIF mode. It should be configured when SAI is disabled. Refer to Section: Output data line management on an inactive slot for more details.
$00000020 constant SAI2_SAI_ACR2_MUTE                               \ Mute. This bit is set and cleared by software. It is meaningful only when the audio block operates as a transmitter. The MUTE value is linked to value of MUTEVAL if the number of slots is lower or equal to 2, or equal to 0 if it is greater than 2. Refer to Section: Mute mode for more details. Note: This bit is meaningless and should not be used for SPDIF audio blocks.
$00000040 constant SAI2_SAI_ACR2_MUTEVAL                            \ Mute value. This bit is set and cleared by software.It must be written before enabling the audio block: SAIXEN. This bit is meaningful only when the audio block operates as a transmitter, the number of slots is lower or equal to 2 and the MUTE bit is set. If more slots are declared, the bit value sent during the transmission in mute mode is equal to 0, whatever the value of MUTEVAL. if the number of slot is lower or equal to 2 and MUTEVAL = 1, the MUTE value transmitted for each slot is the one sent during the previous frame. Refer to Section: Mute mode for more details. Note: This bit is meaningless and should not be used for SPDIF audio blocks.
$00001f80 constant SAI2_SAI_ACR2_MUTECNT                            \ Mute counter. These bits are set and cleared by software. They are used only in reception mode. The value set in these bits is compared to the number of consecutive mute frames detected in reception. When the number of mute frames is equal to this value, the flag MUTEDET will be set and an interrupt will be generated if bit MUTEDETIE is set. Refer to Section: Mute mode for more details.
$00002000 constant SAI2_SAI_ACR2_CPL                                \ Complement bit. This bit is set and cleared by software. It defines the type of complement to be used for companding mode Note: This bit has effect only when the companding mode is -Law algorithm or A-Law algorithm.
$0000c000 constant SAI2_SAI_ACR2_COMP                               \ Companding mode. These bits are set and cleared by software. The -Law and the A-Law log are a part of the CCITT G.711 recommendation, the type of complement that will be used depends on CPL bit. The data expansion or data compression are determined by the state of bit MODE[0]. The data compression is applied if the audio block is configured as a transmitter. The data expansion is automatically applied when the audio block is configured as a receiver. Refer to Section: Companding mode for more details. Note: Companding mode is applicable only when TDM is selected.


\
\ @brief This register has no meaning in AC97 and SPDIF audio protocol
\ Address offset: 0x0C
\ Reset value: 0x00000007
\

$000000ff constant SAI2_SAI_AFRCR_FRL                               \ Frame length. These bits are set and cleared by software. They define the audio frame length expressed in number of SCK clock cycles: the number of bits in the frame is equal to FRL[7:0] + 1. The minimum number of bits to transfer in an audio frame must be equal to 8, otherwise the audio block will behaves in an unexpected way. This is the case when the data size is 8 bits and only one slot 0 is defined in NBSLOT[4:0] of SAI_xSLOTR register (NBSLOT[3:0] = 0000). In master mode, if the master clock (available on MCLK_x pin) is used, the frame length should be aligned with a number equal to a power of 2, ranging from 8 to 256. When the master clock is not used (NODIV = 1), it is recommended to program the frame length to an value ranging from 8 to 256. These bits are meaningless and are not used in AC97 or SPDIF audio block configuration.
$00007f00 constant SAI2_SAI_AFRCR_FSALL                             \ Frame synchronization active level length. These bits are set and cleared by software. They specify the length in number of bit clock (SCK) + 1 (FSALL[6:0] + 1) of the active level of the FS signal in the audio frame These bits are meaningless and are not used in AC97 or SPDIF audio block configuration. They must be configured when the audio block is disabled.
$00010000 constant SAI2_SAI_AFRCR_FSDEF                             \ Frame synchronization definition. This bit is set and cleared by software. When the bit is set, the number of slots defined in the SAI_xSLOTR register has to be even. It means that half of this number of slots will be dedicated to the left channel and the other slots for the right channel (e.g: this bit has to be set for I2S or MSB/LSB-justified protocols...). This bit is meaningless and is not used in AC97 or SPDIF audio block configuration. It must be configured when the audio block is disabled.
$00020000 constant SAI2_SAI_AFRCR_FSPOL                             \ Frame synchronization polarity. This bit is set and cleared by software. It is used to configure the level of the start of frame on the FS signal. It is meaningless and is not used in AC97 or SPDIF audio block configuration. This bit must be configured when the audio block is disabled.
$00040000 constant SAI2_SAI_AFRCR_FSOFF                             \ Frame synchronization offset. This bit is set and cleared by software. It is meaningless and is not used in AC97 or SPDIF audio block configuration. This bit must be configured when the audio block is disabled.


\
\ @brief This register has no meaning in AC97 and SPDIF audio protocol
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000001f constant SAI2_SAI_ASLOTR_FBOFF                            \ First bit offset These bits are set and cleared by software. The value set in this bitfield defines the position of the first data transfer bit in the slot. It represents an offset value. In transmission mode, the bits outside the data field are forced to 0. In reception mode, the extra received bits are discarded. These bits must be set when the audio block is disabled. They are ignored in AC97 or SPDIF mode.
$000000c0 constant SAI2_SAI_ASLOTR_SLOTSZ                           \ Slot size This bits is set and cleared by software. The slot size must be higher or equal to the data size. If this condition is not respected, the behavior of the SAI will be undetermined. Refer to Section: Output data line management on an inactive slot for information on how to drive SD line. These bits must be set when the audio block is disabled. They are ignored in AC97 or SPDIF mode.
$00000f00 constant SAI2_SAI_ASLOTR_NBSLOT                           \ Number of slots in an audio frame. These bits are set and cleared by software. The value set in this bitfield represents the number of slots + 1 in the audio frame (including the number of inactive slots). The maximum number of slots is 16. The number of slots should be even if FSDEF bit in the SAI_xFRCR register is set. The number of slots must be configured when the audio block is disabled. They are ignored in AC97 or SPDIF mode.
$ffff0000 constant SAI2_SAI_ASLOTR_SLOTEN                           \ Slot enable. These bits are set and cleared by software. Each SLOTEN bit corresponds to a slot position from 0 to 15 (maximum 16 slots). The slot must be enabled when the audio block is disabled. They are ignored in AC97 or SPDIF mode.


\
\ @brief Interrupt mask register 2
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant SAI2_SAI_AIM_OVRUDRIE                            \ Overrun/underrun interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt is generated if the OVRUDR bit in the SAI_xSR register is set.
$00000002 constant SAI2_SAI_AIM_MUTEDETIE                           \ Mute detection interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt is generated if the MUTEDET bit in the SAI_xSR register is set. This bit has a meaning only if the audio block is configured in receiver mode.
$00000004 constant SAI2_SAI_AIM_WCKCFGIE                            \ Wrong clock configuration interrupt enable. This bit is set and cleared by software. This bit is taken into account only if the audio block is configured as a master (MODE[1] = 0) and NODIV = 0. It generates an interrupt if the WCKCFG flag in the SAI_xSR register is set. Note: This bit is used only in TDM mode and is meaningless in other modes.
$00000008 constant SAI2_SAI_AIM_FREQIE                              \ FIFO request interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt is generated if the FREQ bit in the SAI_xSR register is set. Since the audio block defaults to operate as a transmitter after reset, the MODE bit must be configured before setting FREQIE to avoid a parasitic interruption in receiver mode,
$00000010 constant SAI2_SAI_AIM_CNRDYIE                             \ Codec not ready interrupt enable (AC97). This bit is set and cleared by software. When the interrupt is enabled, the audio block detects in the slot 0 (tag0) of the AC97 frame if the Codec connected to this line is ready or not. If it is not ready, the CNRDY flag in the SAI_xSR register is set and an interruption i generated. This bit has a meaning only if the AC97 mode is selected through PRTCFG[1:0] bits and the audio block is operates as a receiver.
$00000020 constant SAI2_SAI_AIM_AFSDETIE                            \ Anticipated frame synchronization detection interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt will be generated if the AFSDET bit in the SAI_xSR register is set. This bit is meaningless in AC97, SPDIF mode or when the audio block operates as a master.
$00000040 constant SAI2_SAI_AIM_LFSDETIE                            \ Late frame synchronization detection interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt will be generated if the LFSDET bit is set in the SAI_xSR register. This bit is meaningless in AC97, SPDIF mode or when the audio block operates as a master.


\
\ @brief Status register
\ Address offset: 0x18
\ Reset value: 0x00000008
\

$00000001 constant SAI2_SAI_ASR_OVRUDR                              \ Overrun / underrun. This bit is read only. The overrun and underrun conditions can occur only when the audio block is configured as a receiver and a transmitter, respectively. It can generate an interrupt if OVRUDRIE bit is set in SAI_xIM register. This flag is cleared when the software sets COVRUDR bit in SAI_xCLRFR register.
$00000002 constant SAI2_SAI_ASR_MUTEDET                             \ Mute detection. This bit is read only. This flag is set if consecutive 0 values are received in each slot of a given audio frame and for a consecutive number of audio frames (set in the MUTECNT bit in the SAI_xCR2 register). It can generate an interrupt if MUTEDETIE bit is set in SAI_xIM register. This flag is cleared when the software sets bit CMUTEDET in the SAI_xCLRFR register.
$00000004 constant SAI2_SAI_ASR_WCKCFG                              \ Wrong clock configuration flag. This bit is read only. This bit is used only when the audio block operates in master mode (MODE[1] = 0) and NODIV = 0. It can generate an interrupt if WCKCFGIE bit is set in SAI_xIM register. This flag is cleared when the software sets CWCKCFG bit in SAI_xCLRFR register.
$00000008 constant SAI2_SAI_ASR_FREQ                                \ FIFO request. This bit is read only. The request depends on the audio block configuration: If the block is configured in transmission mode, the FIFO request is related to a write request operation in the SAI_xDR. If the block configured in reception, the FIFO request related to a read request operation from the SAI_xDR. This flag can generate an interrupt if FREQIE bit is set in SAI_xIM register.
$00000010 constant SAI2_SAI_ASR_CNRDY                               \ Codec not ready. This bit is read only. This bit is used only when the AC97 audio protocol is selected in the SAI_xCR1 register and configured in receiver mode. It can generate an interrupt if CNRDYIE bit is set in SAI_xIM register. This flag is cleared when the software sets CCNRDY bit in SAI_xCLRFR register.
$00000020 constant SAI2_SAI_ASR_AFSDET                              \ Anticipated frame synchronization detection. This bit is read only. This flag can be set only if the audio block is configured in slave mode. It is not used in AC97or SPDIF mode. It can generate an interrupt if AFSDETIE bit is set in SAI_xIM register. This flag is cleared when the software sets CAFSDET bit in SAI_xCLRFR register.
$00000040 constant SAI2_SAI_ASR_LFSDET                              \ Late frame synchronization detection. This bit is read only. This flag can be set only if the audio block is configured in slave mode. It is not used in AC97 or SPDIF mode. It can generate an interrupt if LFSDETIE bit is set in the SAI_xIM register. This flag is cleared when the software sets bit CLFSDET in SAI_xCLRFR register
$00070000 constant SAI2_SAI_ASR_FLVL                                \ FIFO level threshold. This bit is read only. The FIFO level threshold flag is managed only by hardware and its setting depends on SAI block configuration (transmitter or receiver mode). If the SAI block is configured as transmitter: If SAI block is configured as receiver:


\
\ @brief Clear flag register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant SAI2_SAI_ACLRFR_COVRUDR                          \ Clear overrun / underrun. This bit is write only. Programming this bit to 1 clears the OVRUDR flag in the SAI_xSR register. Reading this bit always returns the value 0.
$00000002 constant SAI2_SAI_ACLRFR_CMUTEDET                         \ Mute detection flag. This bit is write only. Programming this bit to 1 clears the MUTEDET flag in the SAI_xSR register. Reading this bit always returns the value 0.
$00000004 constant SAI2_SAI_ACLRFR_CWCKCFG                          \ Clear wrong clock configuration flag. This bit is write only. Programming this bit to 1 clears the WCKCFG flag in the SAI_xSR register. This bit is used only when the audio block is set as master (MODE[1] = 0) and NODIV = 0 in the SAI_xCR1 register. Reading this bit always returns the value 0.
$00000010 constant SAI2_SAI_ACLRFR_CCNRDY                           \ Clear Codec not ready flag. This bit is write only. Programming this bit to 1 clears the CNRDY flag in the SAI_xSR register. This bit is used only when the AC97 audio protocol is selected in the SAI_xCR1 register. Reading this bit always returns the value 0.
$00000020 constant SAI2_SAI_ACLRFR_CAFSDET                          \ Clear anticipated frame synchronization detection flag. This bit is write only. Programming this bit to 1 clears the AFSDET flag in the SAI_xSR register. It is not used in AC97or SPDIF mode. Reading this bit always returns the value 0.
$00000040 constant SAI2_SAI_ACLRFR_CLFSDET                          \ Clear late frame synchronization detection flag. This bit is write only. Programming this bit to 1 clears the LFSDET flag in the SAI_xSR register. This bit is not used in AC97or SPDIF mode Reading this bit always returns the value 0.


\
\ @brief Data register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant SAI2_SAI_ADR_DATA                                \ Data A write to this register loads the FIFO provided the FIFO is not full. A read from this register empties the FIFO if the FIFO is not empty.


\
\ @brief Configuration register 1
\ Address offset: 0x24
\ Reset value: 0x00000040
\

$00000003 constant SAI2_SAI_BCR1_MODE                               \ SAIx audio block mode immediately
$0000000c constant SAI2_SAI_BCR1_PRTCFG                             \ Protocol configuration. These bits are set and cleared by software. These bits have to be configured when the audio block is disabled.
$000000e0 constant SAI2_SAI_BCR1_DS                                 \ Data size. These bits are set and cleared by software. These bits are ignored when the SPDIF protocols are selected (bit PRTCFG[1:0]), because the frame and the data size are fixed in such case. When the companding mode is selected through COMP[1:0] bits, DS[1:0] are ignored since the data size is fixed to 8 bits by the algorithm. These bits must be configured when the audio block is disabled.
$00000100 constant SAI2_SAI_BCR1_LSBFIRST                           \ Least significant bit first. This bit is set and cleared by software. It must be configured when the audio block is disabled. This bit has no meaning in AC97 audio protocol since AC97 data are always transferred with the MSB first. This bit has no meaning in SPDIF audio protocol since in SPDIF data are always transferred with LSB first.
$00000200 constant SAI2_SAI_BCR1_CKSTR                              \ Clock strobing edge. This bit is set and cleared by software. It must be configured when the audio block is disabled. This bit has no meaning in SPDIF audio protocol.
$00000c00 constant SAI2_SAI_BCR1_SYNCEN                             \ Synchronization enable. These bits are set and cleared by software. They must be configured when the audio sub-block is disabled. Note: The audio sub-block should be configured as asynchronous when SPDIF mode is enabled.
$00001000 constant SAI2_SAI_BCR1_MONO                               \ Mono mode. This bit is set and cleared by software. It is meaningful only when the number of slots is equal to 2. When the mono mode is selected, slot 0 data are duplicated on slot 1 when the audio block operates as a transmitter. In reception mode, the slot1 is discarded and only the data received from slot 0 are stored. Refer to Section: Mono/stereo mode for more details.
$00002000 constant SAI2_SAI_BCR1_OUTDRIV                            \ Output drive. This bit is set and cleared by software. Note: This bit has to be set before enabling the audio block and after the audio block configuration.
$00010000 constant SAI2_SAI_BCR1_SAIXEN                             \ Audio block enable where x is A or B. This bit is set by software. To switch off the audio block, the application software must program this bit to 0 and poll the bit till it reads back 0, meaning that the block is completely disabled. Before setting this bit to 1, check that it is set to 0, otherwise the enable command will not be taken into account. This bit allows to control the state of SAIx audio block. If it is disabled when an audio frame transfer is ongoing, the ongoing transfer completes and the cell is fully disabled at the end of this audio frame transfer. Note: When SAIx block is configured in master mode, the clock must be present on the input of SAIx before setting SAIXEN bit.
$00020000 constant SAI2_SAI_BCR1_DMAEN                              \ DMA enable. This bit is set and cleared by software. Note: Since the audio block defaults to operate as a transmitter after reset, the MODE[1:0] bits must be configured before setting DMAEN to avoid a DMA request in receiver mode.
$00080000 constant SAI2_SAI_BCR1_NOMCK                              \ No divider
$00f00000 constant SAI2_SAI_BCR1_MCKDIV                             \ Master clock divider. These bits are set and cleared by software. These bits are meaningless when the audio block operates in slave mode. They have to be configured when the audio block is disabled. Others: the master clock frequency is calculated accordingly to the following formula:
$04000000 constant SAI2_SAI_BCR1_OSR                                \ Oversampling ratio for master clock


\
\ @brief Configuration register 2
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000007 constant SAI2_SAI_BCR2_FTH                                \ FIFO threshold. This bit is set and cleared by software.
$00000008 constant SAI2_SAI_BCR2_FFLUSH                             \ FIFO flush. This bit is set by software. It is always read as 0. This bit should be configured when the SAI is disabled.
$00000010 constant SAI2_SAI_BCR2_TRIS                               \ Tristate management on data line. This bit is set and cleared by software. It is meaningful only if the audio block is configured as a transmitter. This bit is not used when the audio block is configured in SPDIF mode. It should be configured when SAI is disabled. Refer to Section: Output data line management on an inactive slot for more details.
$00000020 constant SAI2_SAI_BCR2_MUTE                               \ Mute. This bit is set and cleared by software. It is meaningful only when the audio block operates as a transmitter. The MUTE value is linked to value of MUTEVAL if the number of slots is lower or equal to 2, or equal to 0 if it is greater than 2. Refer to Section: Mute mode for more details. Note: This bit is meaningless and should not be used for SPDIF audio blocks.
$00000040 constant SAI2_SAI_BCR2_MUTEVAL                            \ Mute value. This bit is set and cleared by software.It must be written before enabling the audio block: SAIXEN. This bit is meaningful only when the audio block operates as a transmitter, the number of slots is lower or equal to 2 and the MUTE bit is set. If more slots are declared, the bit value sent during the transmission in mute mode is equal to 0, whatever the value of MUTEVAL. if the number of slot is lower or equal to 2 and MUTEVAL = 1, the MUTE value transmitted for each slot is the one sent during the previous frame. Refer to Section: Mute mode for more details. Note: This bit is meaningless and should not be used for SPDIF audio blocks.
$00001f80 constant SAI2_SAI_BCR2_MUTECNT                            \ Mute counter. These bits are set and cleared by software. They are used only in reception mode. The value set in these bits is compared to the number of consecutive mute frames detected in reception. When the number of mute frames is equal to this value, the flag MUTEDET will be set and an interrupt will be generated if bit MUTEDETIE is set. Refer to Section: Mute mode for more details.
$00002000 constant SAI2_SAI_BCR2_CPL                                \ Complement bit. This bit is set and cleared by software. It defines the type of complement to be used for companding mode Note: This bit has effect only when the companding mode is -Law algorithm or A-Law algorithm.
$0000c000 constant SAI2_SAI_BCR2_COMP                               \ Companding mode. These bits are set and cleared by software. The -Law and the A-Law log are a part of the CCITT G.711 recommendation, the type of complement that will be used depends on CPL bit. The data expansion or data compression are determined by the state of bit MODE[0]. The data compression is applied if the audio block is configured as a transmitter. The data expansion is automatically applied when the audio block is configured as a receiver. Refer to Section: Companding mode for more details. Note: Companding mode is applicable only when TDM is selected.


\
\ @brief This register has no meaning in AC97 and SPDIF audio protocol
\ Address offset: 0x2C
\ Reset value: 0x00000007
\

$000000ff constant SAI2_SAI_BFRCR_FRL                               \ Frame length. These bits are set and cleared by software. They define the audio frame length expressed in number of SCK clock cycles: the number of bits in the frame is equal to FRL[7:0] + 1. The minimum number of bits to transfer in an audio frame must be equal to 8, otherwise the audio block will behaves in an unexpected way. This is the case when the data size is 8 bits and only one slot 0 is defined in NBSLOT[4:0] of SAI_xSLOTR register (NBSLOT[3:0] = 0000). In master mode, if the master clock (available on MCLK_x pin) is used, the frame length should be aligned with a number equal to a power of 2, ranging from 8 to 256. When the master clock is not used (NODIV = 1), it is recommended to program the frame length to an value ranging from 8 to 256. These bits are meaningless and are not used in AC97 or SPDIF audio block configuration.
$00007f00 constant SAI2_SAI_BFRCR_FSALL                             \ Frame synchronization active level length. These bits are set and cleared by software. They specify the length in number of bit clock (SCK) + 1 (FSALL[6:0] + 1) of the active level of the FS signal in the audio frame These bits are meaningless and are not used in AC97 or SPDIF audio block configuration. They must be configured when the audio block is disabled.
$00010000 constant SAI2_SAI_BFRCR_FSDEF                             \ Frame synchronization definition. This bit is set and cleared by software. When the bit is set, the number of slots defined in the SAI_xSLOTR register has to be even. It means that half of this number of slots will be dedicated to the left channel and the other slots for the right channel (e.g: this bit has to be set for I2S or MSB/LSB-justified protocols...). This bit is meaningless and is not used in AC97 or SPDIF audio block configuration. It must be configured when the audio block is disabled.
$00020000 constant SAI2_SAI_BFRCR_FSPOL                             \ Frame synchronization polarity. This bit is set and cleared by software. It is used to configure the level of the start of frame on the FS signal. It is meaningless and is not used in AC97 or SPDIF audio block configuration. This bit must be configured when the audio block is disabled.
$00040000 constant SAI2_SAI_BFRCR_FSOFF                             \ Frame synchronization offset. This bit is set and cleared by software. It is meaningless and is not used in AC97 or SPDIF audio block configuration. This bit must be configured when the audio block is disabled.


\
\ @brief This register has no meaning in AC97 and SPDIF audio protocol
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000001f constant SAI2_SAI_BSLOTR_FBOFF                            \ First bit offset These bits are set and cleared by software. The value set in this bitfield defines the position of the first data transfer bit in the slot. It represents an offset value. In transmission mode, the bits outside the data field are forced to 0. In reception mode, the extra received bits are discarded. These bits must be set when the audio block is disabled. They are ignored in AC97 or SPDIF mode.
$000000c0 constant SAI2_SAI_BSLOTR_SLOTSZ                           \ Slot size This bits is set and cleared by software. The slot size must be higher or equal to the data size. If this condition is not respected, the behavior of the SAI will be undetermined. Refer to Section: Output data line management on an inactive slot for information on how to drive SD line. These bits must be set when the audio block is disabled. They are ignored in AC97 or SPDIF mode.
$00000f00 constant SAI2_SAI_BSLOTR_NBSLOT                           \ Number of slots in an audio frame. These bits are set and cleared by software. The value set in this bitfield represents the number of slots + 1 in the audio frame (including the number of inactive slots). The maximum number of slots is 16. The number of slots should be even if FSDEF bit in the SAI_xFRCR register is set. The number of slots must be configured when the audio block is disabled. They are ignored in AC97 or SPDIF mode.
$ffff0000 constant SAI2_SAI_BSLOTR_SLOTEN                           \ Slot enable. These bits are set and cleared by software. Each SLOTEN bit corresponds to a slot position from 0 to 15 (maximum 16 slots). The slot must be enabled when the audio block is disabled. They are ignored in AC97 or SPDIF mode.


\
\ @brief Interrupt mask register 2
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant SAI2_SAI_BIM_OVRUDRIE                            \ Overrun/underrun interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt is generated if the OVRUDR bit in the SAI_xSR register is set.
$00000002 constant SAI2_SAI_BIM_MUTEDETIE                           \ Mute detection interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt is generated if the MUTEDET bit in the SAI_xSR register is set. This bit has a meaning only if the audio block is configured in receiver mode.
$00000004 constant SAI2_SAI_BIM_WCKCFGIE                            \ Wrong clock configuration interrupt enable. This bit is set and cleared by software. This bit is taken into account only if the audio block is configured as a master (MODE[1] = 0) and NODIV = 0. It generates an interrupt if the WCKCFG flag in the SAI_xSR register is set. Note: This bit is used only in TDM mode and is meaningless in other modes.
$00000008 constant SAI2_SAI_BIM_FREQIE                              \ FIFO request interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt is generated if the FREQ bit in the SAI_xSR register is set. Since the audio block defaults to operate as a transmitter after reset, the MODE bit must be configured before setting FREQIE to avoid a parasitic interruption in receiver mode,
$00000010 constant SAI2_SAI_BIM_CNRDYIE                             \ Codec not ready interrupt enable (AC97). This bit is set and cleared by software. When the interrupt is enabled, the audio block detects in the slot 0 (tag0) of the AC97 frame if the Codec connected to this line is ready or not. If it is not ready, the CNRDY flag in the SAI_xSR register is set and an interruption i generated. This bit has a meaning only if the AC97 mode is selected through PRTCFG[1:0] bits and the audio block is operates as a receiver.
$00000020 constant SAI2_SAI_BIM_AFSDETIE                            \ Anticipated frame synchronization detection interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt will be generated if the AFSDET bit in the SAI_xSR register is set. This bit is meaningless in AC97, SPDIF mode or when the audio block operates as a master.
$00000040 constant SAI2_SAI_BIM_LFSDETIE                            \ Late frame synchronization detection interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt will be generated if the LFSDET bit is set in the SAI_xSR register. This bit is meaningless in AC97, SPDIF mode or when the audio block operates as a master.


\
\ @brief Status register
\ Address offset: 0x38
\ Reset value: 0x00000008
\

$00000001 constant SAI2_SAI_BSR_OVRUDR                              \ Overrun / underrun. This bit is read only. The overrun and underrun conditions can occur only when the audio block is configured as a receiver and a transmitter, respectively. It can generate an interrupt if OVRUDRIE bit is set in SAI_xIM register. This flag is cleared when the software sets COVRUDR bit in SAI_xCLRFR register.
$00000002 constant SAI2_SAI_BSR_MUTEDET                             \ Mute detection. This bit is read only. This flag is set if consecutive 0 values are received in each slot of a given audio frame and for a consecutive number of audio frames (set in the MUTECNT bit in the SAI_xCR2 register). It can generate an interrupt if MUTEDETIE bit is set in SAI_xIM register. This flag is cleared when the software sets bit CMUTEDET in the SAI_xCLRFR register.
$00000004 constant SAI2_SAI_BSR_WCKCFG                              \ Wrong clock configuration flag. This bit is read only. This bit is used only when the audio block operates in master mode (MODE[1] = 0) and NODIV = 0. It can generate an interrupt if WCKCFGIE bit is set in SAI_xIM register. This flag is cleared when the software sets CWCKCFG bit in SAI_xCLRFR register.
$00000008 constant SAI2_SAI_BSR_FREQ                                \ FIFO request. This bit is read only. The request depends on the audio block configuration: If the block is configured in transmission mode, the FIFO request is related to a write request operation in the SAI_xDR. If the block configured in reception, the FIFO request related to a read request operation from the SAI_xDR. This flag can generate an interrupt if FREQIE bit is set in SAI_xIM register.
$00000010 constant SAI2_SAI_BSR_CNRDY                               \ Codec not ready. This bit is read only. This bit is used only when the AC97 audio protocol is selected in the SAI_xCR1 register and configured in receiver mode. It can generate an interrupt if CNRDYIE bit is set in SAI_xIM register. This flag is cleared when the software sets CCNRDY bit in SAI_xCLRFR register.
$00000020 constant SAI2_SAI_BSR_AFSDET                              \ Anticipated frame synchronization detection. This bit is read only. This flag can be set only if the audio block is configured in slave mode. It is not used in AC97or SPDIF mode. It can generate an interrupt if AFSDETIE bit is set in SAI_xIM register. This flag is cleared when the software sets CAFSDET bit in SAI_xCLRFR register.
$00000040 constant SAI2_SAI_BSR_LFSDET                              \ Late frame synchronization detection. This bit is read only. This flag can be set only if the audio block is configured in slave mode. It is not used in AC97 or SPDIF mode. It can generate an interrupt if LFSDETIE bit is set in the SAI_xIM register. This flag is cleared when the software sets bit CLFSDET in SAI_xCLRFR register
$00070000 constant SAI2_SAI_BSR_FLVL                                \ FIFO level threshold. This bit is read only. The FIFO level threshold flag is managed only by hardware and its setting depends on SAI block configuration (transmitter or receiver mode). If the SAI block is configured as transmitter: If SAI block is configured as receiver:


\
\ @brief Clear flag register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant SAI2_SAI_BCLRFR_COVRUDR                          \ Clear overrun / underrun. This bit is write only. Programming this bit to 1 clears the OVRUDR flag in the SAI_xSR register. Reading this bit always returns the value 0.
$00000002 constant SAI2_SAI_BCLRFR_CMUTEDET                         \ Mute detection flag. This bit is write only. Programming this bit to 1 clears the MUTEDET flag in the SAI_xSR register. Reading this bit always returns the value 0.
$00000004 constant SAI2_SAI_BCLRFR_CWCKCFG                          \ Clear wrong clock configuration flag. This bit is write only. Programming this bit to 1 clears the WCKCFG flag in the SAI_xSR register. This bit is used only when the audio block is set as master (MODE[1] = 0) and NODIV = 0 in the SAI_xCR1 register. Reading this bit always returns the value 0.
$00000010 constant SAI2_SAI_BCLRFR_CCNRDY                           \ Clear Codec not ready flag. This bit is write only. Programming this bit to 1 clears the CNRDY flag in the SAI_xSR register. This bit is used only when the AC97 audio protocol is selected in the SAI_xCR1 register. Reading this bit always returns the value 0.
$00000020 constant SAI2_SAI_BCLRFR_CAFSDET                          \ Clear anticipated frame synchronization detection flag. This bit is write only. Programming this bit to 1 clears the AFSDET flag in the SAI_xSR register. It is not used in AC97or SPDIF mode. Reading this bit always returns the value 0.
$00000040 constant SAI2_SAI_BCLRFR_CLFSDET                          \ Clear late frame synchronization detection flag. This bit is write only. Programming this bit to 1 clears the LFSDET flag in the SAI_xSR register. This bit is not used in AC97or SPDIF mode Reading this bit always returns the value 0.


\
\ @brief Data register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant SAI2_SAI_BDR_DATA                                \ Data A write to this register loads the FIFO provided the FIFO is not full. A read from this register empties the FIFO if the FIFO is not empty.


\
\ @brief PDM control register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant SAI2_SAI_PDMCR_PDMEN                             \ PDM enable
$00000030 constant SAI2_SAI_PDMCR_MICNBR                            \ Number of microphones
$00000100 constant SAI2_SAI_PDMCR_CKEN1                             \ Clock enable of bitstream clock number 1
$00000200 constant SAI2_SAI_PDMCR_CKEN2                             \ Clock enable of bitstream clock number 2
$00000400 constant SAI2_SAI_PDMCR_CKEN3                             \ Clock enable of bitstream clock number 3
$00000800 constant SAI2_SAI_PDMCR_CKEN4                             \ Clock enable of bitstream clock number 4


\
\ @brief PDM delay register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000007 constant SAI2_SAI_PDMDLY_DLYM1L                           \ Delay line adjust for first microphone of pair 1
$00000070 constant SAI2_SAI_PDMDLY_DLYM1R                           \ Delay line adjust for second microphone of pair 1
$00000700 constant SAI2_SAI_PDMDLY_DLYM2L                           \ Delay line for first microphone of pair 2
$00007000 constant SAI2_SAI_PDMDLY_DLYM2R                           \ Delay line for second microphone of pair 2
$00070000 constant SAI2_SAI_PDMDLY_DLYM3L                           \ Delay line for first microphone of pair 3
$00700000 constant SAI2_SAI_PDMDLY_DLYM3R                           \ Delay line for second microphone of pair 3
$07000000 constant SAI2_SAI_PDMDLY_DLYM4L                           \ Delay line for first microphone of pair 4
$70000000 constant SAI2_SAI_PDMDLY_DLYM4R                           \ Delay line for second microphone of pair 4


\
\ @brief SAI2 global interrupt
\
$40015c00 constant SAI2_SAI_GCR   \ offset: 0x00 : Global configuration register
$40015c04 constant SAI2_SAI_ACR1  \ offset: 0x04 : Configuration register 1
$40015c08 constant SAI2_SAI_ACR2  \ offset: 0x08 : Configuration register 2
$40015c0c constant SAI2_SAI_AFRCR  \ offset: 0x0C : This register has no meaning in AC97 and SPDIF audio protocol
$40015c10 constant SAI2_SAI_ASLOTR  \ offset: 0x10 : This register has no meaning in AC97 and SPDIF audio protocol
$40015c14 constant SAI2_SAI_AIM   \ offset: 0x14 : Interrupt mask register 2
$40015c18 constant SAI2_SAI_ASR   \ offset: 0x18 : Status register
$40015c1c constant SAI2_SAI_ACLRFR  \ offset: 0x1C : Clear flag register
$40015c20 constant SAI2_SAI_ADR   \ offset: 0x20 : Data register
$40015c24 constant SAI2_SAI_BCR1  \ offset: 0x24 : Configuration register 1
$40015c28 constant SAI2_SAI_BCR2  \ offset: 0x28 : Configuration register 2
$40015c2c constant SAI2_SAI_BFRCR  \ offset: 0x2C : This register has no meaning in AC97 and SPDIF audio protocol
$40015c30 constant SAI2_SAI_BSLOTR  \ offset: 0x30 : This register has no meaning in AC97 and SPDIF audio protocol
$40015c34 constant SAI2_SAI_BIM   \ offset: 0x34 : Interrupt mask register 2
$40015c38 constant SAI2_SAI_BSR   \ offset: 0x38 : Status register
$40015c3c constant SAI2_SAI_BCLRFR  \ offset: 0x3C : Clear flag register
$40015c40 constant SAI2_SAI_BDR   \ offset: 0x40 : Data register
$40015c44 constant SAI2_SAI_PDMCR  \ offset: 0x44 : PDM control register
$40015c48 constant SAI2_SAI_PDMDLY  \ offset: 0x48 : PDM delay register

